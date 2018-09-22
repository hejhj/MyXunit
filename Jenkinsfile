pipeline {
  agent {
    node {
      label 'test'
    }

  }
  stages {
    stage('test') {
      steps {
        bat 'dotnet restore ./MyXunitProject.csproj'
        bat 'dotnet test ./MyXunitProject.csproj'
      }
    }
  }
}