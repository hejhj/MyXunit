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
        sh '''dotnet restore /MyXunitProject.csproj
dotnet test /MyXunitProject.csproj'''
      }
    }
  }
}