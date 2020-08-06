﻿## InspectionProcess

- 
- 
-  
 

## 기능 목록

#### 
----------------------
##### 1. 



##### 2. 


##### 3.
 　    
 


#### 
----------------------
##### 

##### 


##### 


##### 
  
  
  

##

#### 
#### 


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
　    
<img src="https://user-images.githubusercontent.com/63761486/89500295-78677d00-d7fc-11ea-8a4f-7a1db27568d9.jpg" width="70%"></img>

　  

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

### 프리웨어 사용시 팝업광고가 발생하는 문제
<img src="file.png" width="40%" height="30%" title="px(픽셀) 크기 설정" alt="RubberDuck"></img>

------------------------------
#### 증상
 - 3rd party control 중 하나인 Devexpress를 사용하면 프로그램을 실행할 때 마다 devexpress 확장판 구매 독려 광고가 나타남

#### 원인
 - 프리버전의 Devexpress 사용

#### 결과
 - 공개된 광고 제거 소스코드를 인용하여 devexpress 광고 제거 기능을 추가함  
　  






