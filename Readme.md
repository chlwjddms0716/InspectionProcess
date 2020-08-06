## InspectionProcess

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

<img src="https://user-images.githubusercontent.com/63761486/89482951-ef3d4f80-d7d5-11ea-8eda-e87becc529be.jpg" width="80%"></img>

# Point of Interest

### 검색조건 
--------------------------
#### 증상
 
 - 메모리 낭비가 심각함

#### 원인

-  검색조건을 한번에 query문으로 작성하지않고, 조건을 하나씩 검색하여 여러번의 query문을 보냄

#### 결과

- 여러개의 검색조건을 하나의 query문으로 작성하였음
　    
![Query](query.png)

　  

### 여러 곳에서 작업한 결과를 병합하는 중에 생기는 문제
------------------------------
#### 증상
 - 여러 개의 윈폼에 대한 구성 작업을 팀원들과 분업하여 진행하는 상황임
 - 5명의 팀원들이 작업한 결과를 하나의 프로젝트로 병합하려함
#### 원인
 - 어떻게, 무엇을 수정했는지 정보를 공유하기가 복잡하여 많은 시간이 소요됨

#### 결과
 - 위와 같은 문제는 Git 프로그램을 사용하여 해결할 수 있었음 
 - Git은 여러 컴퓨터에서 작업한 결과들을 쉽게 병합해주어 팀 프로젝트 작업 속도 및 효율성을 향상시켜주었음


### 프리웨어 사용시 팝업광고가 발생하는 문제
<img src="file.png" width="40%" height="30%" title="px(픽셀) 크기 설정" alt="RubberDuck"></img>

------------------------------
#### 증상
 - 3rd party control 중 하나인 Devexpress를 사용하면 프로그램을 실행할 때 마다 devexpress 확장판 구매 독려 광고가 나타남

#### 원인
 - 프리버전의 Devexpress 사용

#### 결과
 - 공개된 광고 제거 소스코드를 인용하여 devexpress 광고 제거 기능을 추가함  
　  
 ![Source](Source.png)





