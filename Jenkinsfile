pipeline {
  agent {
    docker {image: 'dotnet-20-rhel7:latest'}
  }
  stages {
    stage('test') {
      steps {
        sh 'id'
        sh 'chmod +x ./runtest.sh'
        sh './runtest.sh'
        //sh 'dotnet restore ./MyXunitProject.csproj'
        //sh 'dotnet test ./MyXunitProject.csproj'
      }
    }
  }
  environment {
    dev = 'dev'
    test = 'test'
  }
}
