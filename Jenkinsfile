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
        dotnet restore ./MyXunitProject.csproj
        dotnet test ./MyXunitProject.csproj
      }
    }
  }
}
