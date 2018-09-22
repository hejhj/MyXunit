pipeline {
  agent {
    node {
      label 'test'
    }

  }
  stages {
    stage('test') {
      steps {
        echo 'hello'
        sh '''dotnet restore ./MyXunitProject.csproj'''
        sh '''dotnet test ./MyXunitProject.csproj'''
      }
    }
  }
}
