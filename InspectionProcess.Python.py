import serial
import time
import requests
import socket
import datetime

ser = serial.Serial('/dev/ttyACM1',9600)

inspectionURL = 'http://10.10.16.121/InspectionProcess.api/api/Inspection/'
inspectionResultURL = 'http://10.10.16.121/InspectionProcess.api/api/InspectionResult/'



# 접속할 서버 주소입니다. 여기에서는 루프백(loopback) 인터페이스 주소 즉 localhost를 사용합니다. 
HOST = '192.168.6.91'

# 클라이언트 접속을 대기하는 포트 번호입니다.   
PORT = 9999

# 소켓 객체를 생성합니다. 
# 주소 체계(address family)로 IPv4, 소켓 타입으로 TCP 사용합니다.  
server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# 포트 사용중이라 연결할 수 없다는 
# WinError 10048 에러 해결를 위해 필요합니다. 
server_socket.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)

# bind 함수는 소켓을 특정 네트워크 인터페이스와 포트 번호에 연결하는데 사용됩니다.
# HOST는 hostname, ip address, 빈 문자열 ""이 될 수 있습니다.
# 빈 문자열이면 모든 네트워크 인터페이스로부터의 접속을 허용합니다. 
# PORT는 1-65535 사이의 숫자를 사용할 수 있습니다.  
server_socket.bind((HOST, PORT))

# 서버가 클라이언트의 접속을 허용하도록 합니다. 
server_socket.listen()

# 무한루프를 돌면서 
while True:
    print('waiting for connection')
# accept 함수에서 대기하다가 클라이언트가 접속하면 새로운 소켓을 리턴합니다. 
    client_socket, addr = server_socket.accept()

# 접속한 클라이언트의 주소입니다.
    print('Connected by', addr)


    print('waiting receive')
    # 클라이언트가 보낸 메시지를 수신하기 위해 대기합니다. 
    data = client_socket.recv(1024)

    # 빈 문자열을 수신하면 루프를 중지합니다. 
    if not data:
        break

    # 수신받은 문자열을 출력합니다.
    print('Received from', addr, data.decode())

    # 받은 문자열을 다시 클라이언트로 전송해줍니다.(에코) 
        
    data = str(data.decode())
    print('data stringfy success')
    dataList = []
    dataList = data.split(',')
    inspectionResultId = -1
    inspectionId = -1
        
    inspectionResultId = int(dataList[0])
    inspectionId = int(dataList[1])
    print(inspectionResultId)
    print(inspectionId)
        
    ser.write(b's')    #send to arduino
    print("send to arduino")
    readData = None
    red =0
    blue = 0
    count = 0
    while count < 2:

        if ser.readable():    #read from arduino
            res = ser.read()
            readData = res.decode()
            print(readData)
            if readData == 'r':
                red = red+1
                count = count+1
            elif readData == 'b':
                blue = blue+1
                count = count+1

    inspectionData = {'FinishTime' : datetime.datetime.now()}
    requests.put(inspectionURL + str(inspectionId), data=inspectionData)
        
    inspectionResultData = {'NormalNumber' : red, 'DefectiveNumber': blue}
    requests.put(inspectionResultURL + str(inspectionResultId), data=inspectionResultData)
    client_socket.sendall(b'e')
    client_socket.close()
    print('sent to DB')
    print(inspectionResultURL + str(inspectionResultId))

# 소켓을 닫습니다.

server_socket.close()



