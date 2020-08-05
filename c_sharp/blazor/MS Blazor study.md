# MS Blazor study

## env

- Microsoft.VisualStudio.BlazorExtension.15.7.20181126.4 설치(새 솔루션에서 만들때 Blazor 선택 없으면 수동으로 깔아주어야함)
- 

```
Version for package `Microsoft.AspNetCore.Blazor.Cli` could not be resolved.
문제는 .net core 3.0때문인것 같음 VS2017에서 지원안함
제거후 2.1만 남기고 돌리니까 돌려짐
그냥 2019깔고

```

# Blazor study

## Intro

### Sartup.cs & Program.cs

### App.razor

- Main page
-  불러오면 @routeData로 찾아서 찾아보고 없으면 not found

### Shared folder

- MainLayout <NavMenu /> @Body 처럼 연결해 줄 수 있음.

### _host.cshtml

- 일반적은 html파일 같음.
- bootstrap, css 같은거 연결해 줄 수 있음. 
- design service of application

```html
<script src="_framework/blazor.server.js"></script>
```

> built-in server js file to communicate back to the server 고칠 필요 없음.

---

## actual pages

### Pages -> Counter, FetchData

```
razor page application -> .cshtml
blazor page application -> .razor
```

### Counter.razor

- @page : 나는 페이지고 /counter로 들어갈 수 있어. path 
- 다음부분은 html 
- @code 부분 : 위에서 쓸 내용들 선언해 줄 수 있음.

 ### Fetchdata.razor

- page => url
- using .Data -> data값 불러오기위해서 using 해줌
- @inject WeatherForecastService ForcastService  -> dependency injection  -> startup.cs에서 services에서 singleton으로 넣어줄 수 있음 inject된 이름을 ForecastService로 받겠다는거.
- 



# 대머리아저씨 

```
webass 

```





















