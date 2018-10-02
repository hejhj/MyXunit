pipeline {
  agent {
    docker {
            image 'openshift/dotnet'
        }
  }
  stages {
    stage('test') {
      steps {
        sh 'dotnet restore ./MyXunitProject.csproj'
        sh 'dotnet test ./MyXunitProject.csproj'
      }
    }
  }
  environment {
    dev = 'dev'
    test = 'test'
  }
}
