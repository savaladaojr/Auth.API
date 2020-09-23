# Auth.API
> Auth.API is a simple ASP.NET Core 3.1 MVC REST API for Authentication purpose.

![GitHub language count](https://img.shields.io/github/languages/count/savaladaojr/Auth.API)
![GitHub top language](https://img.shields.io/github/languages/top/savaladaojr/Auth.API)
![.NET Core](https://github.com/savaladaojr/Auth.API/workflows/.NET%20Core/badge.svg?branch=master)
![GitHub issues](https://img.shields.io/github/issues/savaladaojr/Auth.API)
![GitHub issues](https://img.shields.io/github/issues-raw/savaladaojr/Auth.API)

<br/>

## Description

Authentication is the process of identifying who are the users who can access a resource. On the other hand, authorization is the process of determining what a user can do on the resource to which he has access.

For the authorization process to work, the user must first be authenticated. Then, the application will need the user's identity to identify the user's role and act accordingly.

The Auti.API will handle the authentication. Once the user is authenticated, it will let the caller determine which resource the identity created is allowed to access or not.

After the authentication, the API will send a JSON Web Token back to the caller. This token should be used by the caler in order to make subsequent calls to the API.


If you would like to know more about JSON Web Token, you can access the [Wikipedia article](https://en.wikipedia.org/wiki/JSON_Web_Token/) or search on the internet.

### Features

- [X] Authenticate users
- [X] Generate JSON Web Token
- [X] Protected API Verbs
- [X] Autorize access to specific API Verbs

<br/>
Each API functionality could be access as listed in the table below:

<table>
  <tbody>
    <tr>
      <th>Verb</th>
      <th>URI</th>
      <th>Auth Needed?</th>
      <th>Method</th>
      <th>Description</th>
    </tr>
    <tr>
      <td>GET</td>
      <td>/api/name/authenticate</td>
      <td class='text-align:center'>No</td>
      <td>Authenticate</td>
      <td>Authenticate an user and return a JWT.</td>
    </tr>
    <tr>
      <td>GET</td>
      <td>/api/name/{id}</td>
      <td class='text-align:center'>Yes</td>
      <td>Get By ID</td>
      <td>Get an user information</td>
    </tr>    
    <tr>
      <td>GET</td>
      <td>/api/name</td>
      <td class='text-align:center'>Yes</td>
      <td>Get All Users</td>
      <td>Get All Users information</td>
    </tr>
  </tbody>
</table>


## Installation

### Pre-requisites

1. .Net Core SDK installed;
2. Visual Studio 2019 (Comunity) installed;

### Cloning the Repository

1. Create a project's directory on your computer;
2. Clone the repository.

```bash
git clone https://github.com/savaladaojr/Auth.API
```

## Running the API

#### Opening the project

1. Double click on the solution file. It will open the solution in your current version of the Visual Studio.


### Restoring project's dependencies

1. In the Visual Studio, open the Package Manager Consol and run the command to restore all packages used by the API. You can also click-right on the solution's name in the Solution Explorer and select "Restore NuGet Packages.

```sh
dotnet restore
```

### Building & Running the API

1. To build the project you have two options: The first one is click-right on the solution's name and then select "Build Solution". The second option is by running the command below through the Package Manager Console terminal;

```sh
dotnet build
```

2. To Run the API, there are also two options: Pressing F5 or executing the command through the terminal. 

```sh
dotnet run
```


## Consuming the API.

To run some tests on the API, I recommend that you download [Postman](https://www.postman.com/downloads/) or also use a Google Chrome plug-in. You also have another option which is [Insomina](https://insomnia.rest/download/). Both are gonna work and have a free version.

I'm using Postman! So I have already prepared a file with all requests for the API. You can find this file (Auth.API.postman_collection.json) in the repository.

So, later I'll create a project to consuming this API and show how to use it in a different approach.

<br/><br/><br/>


## Contributing

1. Fork it (<https://github.com/savaladaojr/Auth.API/fork>);
2. Create your feature branch (e.g. `git checkout -b feature/fooBar`);
3. Commit your changes (e.g. `git commit -am 'Add some fooBar'`);
4. Push to the branch (e.g. `git push origin feature/fooBar`);
5. Create a new Pull Request.

<br/><br/><br/><br/><br/>
###### This API was built for learning purposes.
