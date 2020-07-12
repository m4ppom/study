# Programming in Blazor - ASP.NET Core 3.2

---

## 1.Intro

---

### Advantages of using blazor

- .NET Ecosystem
- C# (LINQ, asynchronous programming)
- Working with components

```
the client side model(blazor WebAssembly) 
```

### Blazor WebAssembly

- WebAssembly to execute .NET apps in web browser

  -Highly scalable(adv) 

  -Downloading .NET runtime +  DLLs (dis-adv)

- Blazor (client side)

- Blazor (client side + ASP.NET Core)

![1594427675705](images/assem_vs_server.png)

https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor

![1594429486203](images/download1.png)

```
실행-> powershell -> dotnet --version 
```

---

## 2. Razor

---

- cshtml속 @을 통해 사용할 수 있음

Pages -> Index.razor

```
@page "/"
	<p>Hi,@name</p>

@code{
	string name = "Marsa"
}
```

- code 부분에 c#코드 넣을 수 있고 page부분에 html 문법 사용가능
- @을 통해 code에서 정의한 것 사용

























