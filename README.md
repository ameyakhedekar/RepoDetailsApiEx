## Introduction
RepoDetailsApi is designed to return information of public repository.
It has a Health endpoint which returns the repo details of the curent project


## Pre requisites/ dependencies to run the project:
  * Enable Kubernetes on docker desktop.
  * Make sure that the nodes are running(command: kubectl get nodes)


## How to Run the project:
1. Go into the project folder.
2. Run deployment\deploy.bat
3. You should be able to access the swagger: http://localhost:8091/swagger/index.html
4. Check endpoint http://localhost:8080/Health


## Artifacts/Folders
### src:
* The source code of the api. It is developed in .net core 5.0


### deployment/CI CD pipleline
* This web api would ideally be deployed on a Kubernetes hosting environment on the cloud such as ECS. 
* This folder contains a batch file(_deploy.bat_) which can be run to deploy the web api locally. 
* The _deploy.bat_ has some key steps which we would execute on a CI/CD Server.


### k8s
* The artifacts (deployment and service yaml files) to deploy the container on Kubernetes
  

## Limitations and Improvements
* Build CI/CD pipeline in a tool. The instructions are based in the _deploy.bat_ file. Tagging for release is manual, but would be ideally be done by the CI CD pipeline.
* Write unittests for the projects/Extend it with TDD development.
* There is rate limiting with the public endpoint with github(https://api.github.com). Would need to add authentication to extend that.