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

- 생산품에 배정된 검사조를 확인 할 수 있다.
  
  

<img src="https://user-images.githubusercontent.com/63761322/89505070-fb400600-d803-11ea-9711-fb21eaa79501.JPG" width="40%"></img>

- 작업지시 할 행을 선택하여 작업지시 버튼을 클릭하고 검사조를 배정하면 작업이 시작된다.
  
  

                                                                                                                                                                                                                                                 
------------------------------                                                                                                                                                                                 
#### 3. 품질관리

<img src="https://user-images.githubusercontent.com/63761322/89503918-35a8a380-d802-11ea-9fd5-e02e6fb2aa0a.JPG" width="60%"></img>

- 생산품을 검사 한 결과를 볼 수 있으며, 검사횟수를 확인 할 수 있다.
- 재검사를 눌렀을 경우 검사조를 배정하여 검사를 다시 할 수 있다.


------------------------------


#### 4. 입고관리

<img src="https://user-images.githubusercontent.com/63761322/89503912-33464980-d802-11ea-93ea-5282938cd874.JPG" width="60%"></img>

- 검사횟수는 최대 3번으로 검사 횟수가 3번이거나 양품개수 10개인 경우 자동으로 창고로 입고된다
- 검사 ID를 보고 창고명 , 개수 , 입고날짜를 확인 할 수 있다.


------------------------------


#### 5. 창고관리
<img src="https://user-images.githubusercontent.com/63761322/89503913-33dee000-d802-11ea-8ac2-0dca929a92ab.JPG" width="60%"></img>

- 창고에 따라 개수를 확인 할 수 있다.
- 비우기 버튼을 사용하여 창고에 있는 생산품을 출고하거나, 폐기 할 수 있다.



------------------------------



#### 5. 설비관리

<img src="https://user-images.githubusercontent.com/63761322/89503914-34777680-d802-11ea-8e82-a5355ce9d8a7.JPG" width="60%"></img>


- 검사 ID에 따라 검사 설비가 언제 시작했고 언제 끝났는지 볼 수 있다.

------------------------------

#### 6. 실시간 상태


<img src="https://user-images.githubusercontent.com/63761322/89510373-73f69080-d80b-11ea-9ec1-4344f4fc2914.png" width="60%"></img>


- 온/습도 보기버튼을 클릭하여 현장의 환경을 볼 수 있다.
- 창고에 생산품이 얼마나 들어가 있는지 확인 할 수 있고, 개수에 따라 창고 이미지가 바뀐다.
- CCTV 버튼을 클릭하여 실시간 공정화면을 확인 할 수 있다.


<img src="https://user-images.githubusercontent.com/63761322/89510717-e7000700-d80b-11ea-9c1d-9b31dbf2ed6c.png" width="60%"></img>



                                                                                                                          
                                                                                                                          












 　    
 
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
***

# 시퀀스 다이어그램

![SequenceDiagram](https://user-images.githubusercontent.com/63270925/89602551-f3cf3a00-d8a1-11ea-9e72-fe9edcb19978.png)    


***
# 센서 제어 알고리즘  
![알고리즘 다이어그램](https://user-images.githubusercontent.com/63270925/89598299-71417d00-d897-11ea-8985-5b2d0279efd4.png)   


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
 -  소켓을 이용하여 서버와 클라이언트의 역할을 바꿈. 장비(라즈베리파이)가 소켓 서버를 활성화하고, 애플리케이션(윈폼)이 소켓 클라이언트로서 연결함
　  
<img src="https://user-images.githubusercontent.com/63761322/89503098-080f2a80-d801-11ea-8507-e84d0af63d55.JPG" width="50%"></img>



### 폼의 상속으로 코드의 중복을 최소화
------------------------------
#### 원인
 - 등록과 수정을 위해 추가적인 폼을 만들어야 했고, 쓰임새나 폼의 디자인이 유사함      
<img src="https://user-images.githubusercontent.com/63270925/89598949-1e68c500-d899-11ea-956a-3c2979a35ec9.png" width="30%"></img>

#### 해결
 - 추가적으로 생성되는 폼을 ChildRootForm이라는 부모 폼을 만들어 상속받게 함      
 <img src="https://user-images.githubusercontent.com/63270925/89599593-fc704200-d89a-11ea-9048-53415438dd0c.png" width="40%"></img>

 - 버튼의 기능이 상속되기 때문에 자식폼에서 필요할 경우에 override함    
 - 반드시 상속해야하는 경우 virtual 메서드에 NotImplimentedException을 throw해서 override되지 않았음을 알게 함    
 - abstract 클래스로 만드는 방법도 있음    
<img src="https://user-images.githubusercontent.com/63270925/89599775-6852aa80-d89b-11ea-80f5-8fd6ab45921c.png" width="50%"></img>     
 

