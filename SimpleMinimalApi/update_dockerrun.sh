DOCKER_IMAGE_URI=$1

cat > Dockerrun.aws.json << EOL
{
  "AWSEBDockerrunVersion": "1",
  "Image": {
    "Name": "${DOCKER_IMAGE_URI}",
    "Update": "true"
  },
  "Ports": [
    {
      "ContainerPort": "80"
    }
  ]
}
EOL