pipeline {
  agent {
    node {
      label 'test'
    }

  }
  stages {
    stage('test') {
      steps {
        bat(script: 'dotnet restore ./MyXunitProject.csproj dotnet test /MyXunitProject.csproj', returnStatus: true)
        bat(script: 'dotnet test ./MyXunitProject.csproj dotnet test /MyXunitProject.csproj', returnStatus: true)
      }
    }
  }
}