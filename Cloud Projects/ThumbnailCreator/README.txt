
0.  Extract all files from winstonmFinalProject.zip (DON'T EXTRACT CreateThumbnail.zip!!!)
1.  Have two buckets ready to go with the names [insertnamehere] and [insertnamehere]resize
2.  Create an IAM user in your AWS management with the name adminuser with AdministatorAccess
with Programmatic access and AWS Management Console Access
3. Create an IAM role in your AWS console with the following info:

  Service Type - AWS Lambda
  Permission Policies:  AWSLambdaBasicExecuteRole and AmazonS3FullAccess

Keep a note of the ARN number for the role

4. Run the following code in your CLI

$ aws lambda create-function \
--region us-west-2 \
--function-name CreateThumbnail \
--zip-file fileb://<file-path>/CreateThumbnail.zip \
--role <role-arn> \
--handler CreateThumbnail.handler \
--runtime nodejs6.10 \
--profile adminuser \
--timeout 10 \
--memory-size 1024

Replace any code in <> with appropriate values

4. Run the following code in your CLI (if on Linux or Mac, switch out \ for ^ if on Windows)

$ aws lambda add-permission \
--function-name CreateThumbnail \
--region us-west-2 \
--statement-id <some-unique-id> \
--action "lambda:InvokeFunction" \
--principal s3.amazonaws.com \
--source-arn arn:aws:s3:::<sourcebucket> \
--source-account <bucket-owner-account-id> \
--profile adminuser

Replacing the parts in <> with the appropriate values

5. Go to your regular S3 bucket, click on it, and go to the Properties tab
6.  Scroll down to Events, click on it, and click Add Notification
7. Give the event a name, select ObjectCreate(All) for events and for Send To select Lambda Function
and select your function.  Finally hit save.
