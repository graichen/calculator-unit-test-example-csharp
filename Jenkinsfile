#!/usr/bin/env groovy

pipeline {
    agent any

    options {
        buildDiscarder(logRotator(numToKeepStr: '10'))
    }

    environment {
        HTTP_PROXY="${HTTP_PROXY}"
        HTTPS_PROXY="${HTTPS_PROXY}"
        NO_PROXY="${NO_PROXY}"
        SONAR_LOGIN_KEY = credentials('SONAR_LOGIN_KEY')
    }

    stages {

        stage('Check env') {
            steps {
                sh 'id'
                sh 'env'
                sh 'docker version'
            }
        }

        stage('Test') {
            agent {
                docker {
                    // to run as non-root:
                    image 'mcr.microsoft.com/dotnet/core/sdk:3.1.401-alpine3.12'
                    //args '-u ${JENKINS_UID}'
                    // for windows let's skip setting user
                    //args '-u root:root'
                }
            }
            steps {
                sh 'id'
                sh 'dotnet build CalculatorApp/CalculatorApp.sln --configuration Release'
                    
            }
        }
    }
//    post {
//        unstable {
//            mail to: "${env.CHANGE_AUTHOR_EMAIL}",
//                    subject: "Unstable Pipeline: ${currentBuild.fullDisplayName}",
//                    body: "Something is wrong with ${env.BUILD_URL}"
//        }
//        failure {
//            mail to: "${env.CHANGE_AUTHOR_EMAIL}",
//                    subject: "Failed Pipeline: ${currentBuild.fullDisplayName}",
//                    body: "Something is wrong with ${env.BUILD_URL}"
//        }
//        aborted {
//            mail to: "${env.CHANGE_AUTHOR_EMAIL}",
//                    subject: "Aborted Pipeline: ${currentBuild.fullDisplayName}",
//                    body: "Something is wrong with ${env.BUILD_URL}"
//        }
//        changed {
//            mail to: "${env.CHANGE_AUTHOR_EMAIL}",
//                    subject: "Changed Pipeline: ${currentBuild.fullDisplayName}",
//                    body: "Something is changed with ${env.BUILD_URL}"
//        }
//    }
}