S3_BUCKET="$1"
FILE_NAME="$3"

FILE_EXISTS=$(aws s3 ls "s3://${S3_BUCKET}/${FILE_NAME}" 2>&1)

if [ $? -eq 0 ]; then
    echo "${FILE_NAME} exists. Downloading and updating docker-compose.yml..."
    
    # download latest docker-compose.yml file
    aws s3 cp s3://${S3_BUCKET}/${FILE_NAME} .
    RUN_ID=$(cat ${FILE_NAME}).zip
    aws s3 cp s3://${S3_BUCKET}/$RUN_ID .
    # overwrite existing docker-compose.yml file
    echo 'y' | unzip $RUN_ID -d .
    ls
    cat docker-compose.yml

else
    echo "${FILE_NAME} does not exist. Using default docker-compose.yml..."
fi