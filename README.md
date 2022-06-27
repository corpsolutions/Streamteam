<div id="top"></div>

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/corpsolutions/Streamteam">
    <img src="img/thecorp.png" alt="Logo" width="250" height="250">
  </a>

<h1 align="center">Streamteam</h1>

  <p align="center">
    <h6>Big team, big opportunities, simple solution.</h6>
    <a href="#"><strong>Explore the docs »</strong></a>
    <br />
    <a href="#">View site</a>
    ·
    <a href="#">For developer</a>
    ·
    <a href="#">Contact</a>
  </p>
</div>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
        <ul>
            <li><a href="#motivation">Motivation</a></li>
        </ul>
        <ul>
            <li><a href="#built-with">Built With</a></li>
        </ul>
    </li>
    <li><a href="#getting-started">Getting Started</a></li>
    <li><a href="#installation">Installation</a></li>
    <li><a href="#licence">Licence</a></li>

  </ol>
</details>

<!-- ABOUT THE PROJECT -->
<div id="about-the-project"></div>

## About The Project

<strong>Streamteam</strong> is an open-source collaboration platform for improving the productivity of teams and
organizations. </br>
We want to facilitate and automate boring team processes. And also to make teamwork more enjoyable and productive.</br>

<h4>Basic platform capabilities:</h4>

- Team chat</br>
- Event management</br>
- File sharing and file storage</br>
- Task management</br>
- Real-time collaboration docs</br>
- Video call and conference</br>
- Knowledge management</br>

<p align="right">(<a href="#top">back to top</a>)</p>

<div id="built-with"></div>

<div id="motivation"></div>

### Motivation

We live in an era of digital blockade of big IT companies. By using proprietary software for business, you risk becoming
hostage to political, economic and other factors. We aim to ensure that in every area of human life, when choosing which
software to use, there is always an alternative in the form of open-source applications, and that this alternative is
not limited to one or two applications.
In the area of teamwork applications and good open-source programs are sufficient.

Below is a list of some of them:

- [Mattermost](https://mattermost.com/)
- [Rocket chat](https://rocket.chat/)
- [Next Cloud](https://nextcloud.com/)
- [Twake](https://twake.app/) </br>
  _A more extensive list will be added in the future._

Our goal is to create a distributed platform, on a microservice architecture, to be able to complement and extend the
capabilities of the digital command space. This platform is developed like a puzzle, each service is a small part of the
whole service, while at the same time it is completely autonomous. Teams must be able to select the options they need,
disable unnecessary ones, and augment existing ones.</br>
<strong>We do not strive to be better than others, we strive to give choices.</strong>

<p align="right">(<a href="#top">back to top</a>)</p>

### Built With

The technologies on which the system is based are listed below.

* [.Net Core 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0)
* [PostgresSQL](https://www.postgresql.org/)
* [Docker](https://www.docker.com/)
* [React](https://reactjs.org/)

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- GETTING STARTED -->
<div id="getting-started"></div>

## Getting Started for contributing

We appreciate your willingness to contribute to the development of the project. All the necessary actions, we have
[contributing](docs/Contribution/Index.md) in the documentation section. If you have any questions, feel free
to [create an issue](https://github.com/corpsolutions/Streamteam/issues/new) on github.

<div id="installation"></div>

## Installation

The system is deployed using docker images. Each microservice is a separate docker image. There are a number of
obligatory services to be deployed on the host. Such as "**Identity service**", "**Workspace service**" and
"**Accounting service**". All others you can deploy based on your needs.

1. Clone the repo
   ```sh
   git clone https://github.com/corpsolutions/Streamteam
   ```
2.

<p align="right">(<a href="#top">back to top</a>)</p>


<!-- Licence -->
<div id="licence"></div>

## Licence

Streamteam is licensed under the [AGPL-3.0](LICENSE).

<p align="right">(<a href="#top">back to top</a>)</p>
