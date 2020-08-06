## InspectionProcess


#### 개요 
- 스마트팩토리의 여러 라인중 불량품 판별공정을 C# EntityFrameWork 와 RasBerryPi의 Thonny Python IDE , Arduino 통신을 이용해 구현하였다.
 

## 기능 목록


#### 1. 생산관리

<img src="https://user-images.githubusercontent.com/63761322/89504584-3b52b900-d803-11ea-8b98-1696986ddb4b.JPG" width="60%"></img>


- 상품명과 생산조를 이용하여 검색을 할 수 있고, 검색조건 초기화를 눌러서 검색조건을 초기화 할 수 있다.
- 실수로 등록하였을 경우 삭제버튼 눌러 삭제 할 수 있다.
  
  


<img src="https://user-images.githubusercontent.com/63761322/89504399-df883000-d802-11ea-8d98-118084472b50.JPG" width="40%"></img>


- 생산이 다 끝나면 상품명, 생산완료일, 생산완료시각, 생산조를 적어서 등록할 수 있다.
  
  

------------------------------                                                                                                                      
#### 2. 작업관리

<img src="https://user-images.githubusercontent.com/63761322/89503917-35100d00-d802-11ea-9bf4-246fdb2bc28e.JPG" width="60%"></img>

- 생산ID와 상품명을 이용하여 검색을 할 수 있다.
  
  

<img src="https://user-images.githubusercontent.com/63761322/89505070-fb400600-d803-11ea-9711-fb21eaa79501.JPG" width="40%"></img>

- 작업지시 할 행을 선택하여 작업지시 버튼을 클릭하고 검사조를 배정하면 작업이 시작된다.
  
  

                                                                                                                                                                                                                                                 
------------------------------                                                                                                                                                                                 
##### 3. 품질관리

<img src="https://user-images.githubusercontent.com/63761322/89503918-35a8a380-d802-11ea-9fd5-e02e6fb2aa0a.JPG" width="60%"></img>

- 검사ID와 생산품ID와 검사조를 이용하여 검색 할 수 있다.



 　    
 
# 사용 기술

### 언어

* C/C++
* Python
* C# 3.0+

### 프레임워크

* Arduino
* Thonny Python IDE
* .Net FrameWork 4.8+
* Winform
* EntityFrameWork 6.2+

### 3rd-Pary Control

* DevExpress Winform

### 데이터베이스

* MSSQL Server 2019  
  　

# 데이터베이스 스키마

<img src="https://user-images.githubusercontent.com/63761486/89498131-9d59f100-d7f8-11ea-8404-363ee25799c7.jpg" width="80%"></img>

# Point of Interest

### 검색조건을 DB로부터 불러올 시에 리스트가 다 나올때까지 멈추는 문제 
--------------------------
#### 증상
 
- 검색조건을 누르면 폼이 멈춤

#### 원인

- 동기적 프로그래밍을 하여서 요청을 하면 그 즉시 결과가 주어져야 하기 때문에 다 나올때까지 아무것도 못함

#### 결과

- 동기적프로그래밍을 비동기적 프로그래밍으로 바꿨음
- 비동기적 프로그래밍은 요청을 하면 그 즉시 결과가 주어지지 않아도 되기 때문에 리스트를 불러올때까지 다른 일을 할 수 있음
　    
<img src="https://user-images.githubusercontent.com/63761486/89500295-78677d00-d7fc-11ea-8a4f-7a1db27568d9.jpg" width="80%"></img>

　  

### 여러 폼들에서 같은 기능과 모양을 가진 버튼을 수정할 때 여러번 수정해야하는 번거로움 
------------------------------
#### 증상

 - 버튼에 수정사항이 생길 경우 그 버튼을 가진 모든 폼에 들어가서 수정해줘야함
 
#### 원인

 - 같은 기능과 모양을 가진 버튼인데 일일히 폼에 넣어주었음

#### 결과
 - 같은 기능과 모양 가진 버튼들을 유저컨트롤로 묶었음
 - 이벤트 생성기 프로그램을 이용하여 유저컨트롤에서 이벤트를 만들어서 다른 폼에서도 이벤트핸들러로 쓸 수 있게 만들었음
 
<img src="https://user-images.githubusercontent.com/63761486/89500330-861d0280-d7fc-11ea-832e-f8dc98f701e4.jpg" width="50%"></img>

### 윈폼에서  이용하여 라즈베리파이의 센서를 작동시키고 싶은데 전달이 어려운 경우  

------------------------------
#### 증상
 - 윈폼은 서버고 라즈베리파이 센서들은 클라이언트라 지시를 내리기 어려움

#### 원인
 - 윈폼에서 작업지시를 내렸을 때 라즈베리파이 센서들을 작동시키고 싶은데 방법을 잘 몰랐음

#### 결과
 -  소켓을 이용하여 서버와 클라이언트의 역할을 바꿈 소켓을 이용하면 파이썬은 서버 C#은 클라이언트가 됨 
　  
<img src="https://user-images.githubusercontent.com/63761322/89503098-080f2a80-d801-11ea-8507-e84d0af63d55.JPG" width="50%"></img>




