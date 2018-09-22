pipeline {
  agent {
    node {
      label 'test'
    }

  }
  stages {
    stage('test') {
      steps {
        bat 'dotnet restore ./MyXunitProject.csproj dotnet test /MyXunitProject.csproj'
        bat 'dotnet test ./MyXunitProject.csproj dotnet test /MyXunitProject.csproj'
      }
    }
  }
}