# rhrhRPA antbot











## excel

```
excel open scope
int32[] ==> array of <> 에서 자료형 선택해서 만들 수 있음.

invoke method 함수 사용하게 해주는거 파라미터들 넣을 수 있음.... 대소문자 구분함

data table은 assign말고 dataTable copy로 카피해서 invoke할 수 있음

list 정의 list<T> 기본값에 new list(of string) 
dictionary: new dictionary(string, integer)초기화
list<T>.add
addToCollection사용해서 넣어줄 수 있음


```

### main.xaml

```
Assign |	keyindex = 0
			sumindex = new List(of integer) ({2,3,4}) // 해당 열 리스트로 가져올꺼
			
			
excelOpenScope => excel 파일 지정
			excel 읽기 range =>시트지정해서 읽음 헤더 포함, Data Table명 설정해줘야 읽은거 넣어줌
			
invoke Xaml		| 	다른 xaml파일로 인수들 보내고 받는역할
					
```

### data처리.xaml

```
DataTable Foreach	|	Foreach row in InputDt == inputDT안에 열 값을 row라고해서 돌림
Assign			|	dickey = row(indexKey).ToString

If				|	dic.Keys.Contains(DicKey) 딕셔너리 안에 키 있는지 condition 설정

	Then	|	assign 	|	buf = dic(DicKey)
	Else	|	assign	|	buf = new List(of integer)
				ForEachgeneric	|	Foreach item in IndexSum
				InvokeMethod	|	TargetType	:	null	목표로하는 타겟
									TargetObject:	buf
									Methodname	:	Add		Add메소드 사용가능
									
ForEachGeneric		|	Foreach inSum in indexSum
						assign	|	buf(idx) = buf(idx)+cint(row(inSum).ToString)

assign		|	dic(DicKey) = buf
키컬럼추가		|	DT명,	column명
ForEachGeneric		|	Foreach item in dic.Keys
					Assign		| 	row1 = outdt.NewRow
									row1(InputDT.Columns(IndexKey).ColumnName) = item
					ForEachGeneric	|	Foreach item in IndexSum
									Assign	|	row1(InputDT.Columns(IndexKey).ColumnName) = vuf(idx)

DataTable에 추가
DataTable Copy 데이타 테이블을 카피해서 invoke 출력부분으로 보내버림.

									
						
									
```



```
딕셔너리 넣을 때 초기화해줘야함 dictionary
DataTable 넣을때 인덱스처럼 DT(0)(0)이런식으로 assign으로 넣을 수 있음.

```

# 데이터테이블 DT

## 값 변경, 삽입

```

dataTable( row 인덱스 )( col 이름이나 인덱스 )  = 들어갈 값 or 변경할 값

== datarow사용 ==
datarow 선언해주고 assign으로  
datarow이름 = 사용할 DT   (형태받아오기위해)
datarow("column명") = 들어갈 값

#####row 추가 액티비티 사용 ######


```



## 열추가

```
액티비티 dataTable에 Column추가 사용
Column이름 == Header 등록 가능

```





# 딕셔너리 Dic

```
선언할 때 
assign  액티비티
dic이름 = New Dictionary(Of string, DataTable) 	선언해주고 사용해야
```



## List

```
contains로 안에 정보 확인할 수 있음.

```



# flowdecision	

```
조건을 플로우디시전을 사용해서 걸어줄 수 있음.

```



## UI AUTO

```
값을 찾을 때 속성값을 DT에서 받아와서 변수를 넣어주는 형식으로 원하는 속성 크롤링 가능.

```



## Trim

```c#
-trim 		문자열의 시작과 끝의 문자 배열에서 지정하는 문자 제거 가능
string_word.trim
    
-trimend  	새 문자열 개체를 생성해줌 끝에서 문자를 제거.마지막단어, 첫번쨰 단어 제거.
    
```



```
리스트 0건일때 ==== 있을때 조건.

```



