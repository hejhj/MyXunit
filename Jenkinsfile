pipeline {
  agent { dockerfile true }
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
