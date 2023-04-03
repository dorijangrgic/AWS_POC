S3_BUCKET="$1"
ENV_DIR="$2"
FILE_NAME="$3"

FILE_EXISTS=$(aws s3 ls "s3://${S3_BUCKET}/${ENV_DIR}/${FILE_NAME}" 2>&1)

if [ $? -eq 0 ]; then
    echo "${FILE_NAME} exists. Downloading and updating docker-compose.yml..."
    
    # download latest docker-compose.yml file
    aws s3 cp s3://${S3_BUCKET}/${ENV_DIR}/${FILE_NAME} .
    RUN_ID=$(cat ${FILE_NAME}).zip
    aws s3 cp s3://${S3_BUCKET}/${ENV_DIR}/$RUN_ID .
    # overwrite existing docker-compose.yml file
    unzip $RUN_ID -d .
    ls

else
    echo "${FILE_NAME} does not exist. Using default docker-compose.yml..."
fi