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

![powershell1](images/powershell1.png)



---

## 2. Razor

---

- cshtml속 @을 통해 사용할 수 있음

Pages -> Index.razor

```
@page "/"
<p>Hello, @name.ToUpper()</p>
<p>hi, @CustomToUpper(name)</p>
<p>let's add 2+2 = @(2+2)</p>
<button @onclick="@(() => Console.WriteLine("I've been clicked"))">push me</button>
<button @onclick="@WriteInLog">push me</button>

<h1>Hello, world!</h1>

Welcome to your new app.

<SurveyPrompt Title="How is Blazor working for you?" />

@code{
    string name = "Marsa";
    string CustomToUpper(string value) => value.ToUpper();

    void WriteInLog()
    {
        Console.WriteLine("I've been CLICKED!!!");
    }
}
```

- code 부분에 c#코드 넣을 수 있고 page부분에 html 문법 사용가능
- @을 통해 code에서 정의한 것 사용



### Class

- Local class는 같은 파일안 @code부분에 클래스 선언해서 사용하는것.(스코프가 해당 파일에만 적용되므로 한정적으로 사용됨)
- 다른 클래스 모음파일 만들어서 using을 통해 불러 올 수 있음. (using + namespace)

- _imports.razor :  can define using a statements that will be applied to every Razor file in the client project.

### Loop

- for , foreach 사용가능 code 부분에서 선언해주고 불러올 수 있음.

### Async

- 지연을 줄 수 있음

```csharp
 List<Movie> movies;
    protected async override Task OnInitializedAsync()
    {
        await Task.Delay(3000);
        movies = new List<Movie>()
        {
            new Movie(){Title = "Spider-man : Far From Home", Releasedate = new DateTime(2019,7,2)},
            new Movie(){Title = "Moana", Releasedate = new DateTime(2016, 11, 23)},
            new Movie(){Title = "Inception", Releasedate = new DateTime(2010, 7, 16)}
        };
    }
```

## 3.Components

- shared folder에 razor file생성하고 그 안에 선언한 내용을 다른 파일에서 불러 올 수 있음 <MoviesList/>

> Shared => MoviesList.razor

```csharp
@if (movies == null)
{
    <text>loading...</text>
}
else if(movies.Count == 0)
{
    <text>There are no records to show</text>
}
else
{
    @foreach (var movie in movies)
    {
        <p>Title : @((MarkupString)movie.Title)</p>
        <p>Release Date : <b>@movie.Releasedate.ToString("dd MMM yyy")</b></p>
    }
    <hr />
    @for (var i = 0; i < movies.Count; i++)
    {
        <p>Title : <b>@movies[i].Title</b></p>
        <p>Release Date : <b>@movies[i].Releasedate.ToString("dd MMM yyy")</b></p>
    }
}

@code {
    List<Movie> movies;
    protected  override void OnInitialized()
    {
        movies = new List<Movie>()
        {
            new Movie(){Title = "Spider-man : Far From Home", Releasedate = new DateTime(2019,7,2)},
            new Movie(){Title = "Moana", Releasedate = new DateTime(2016, 11, 23)},
            new Movie(){Title = "Inception", Releasedate = new DateTime(2010, 7, 16)}
        };
    }
}

```

### Parameter

- [parameter] code에 넣어서 

```csharp
[Parameter] public List<Movie> Movies { get; set; }
```

shared에서 선언된거 가져올 수 있음





















