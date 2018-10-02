pipeline {
  agent any

  }
  stages {
    stage('test') {
      steps {
        bat 'dotnet restore ./MyXunitProject.csproj'
        bat 'dotnet test ./MyXunitProject.csproj'
      }
    }
  }
  environment {
    dev = 'dev'
    test = 'test'
  }
}
