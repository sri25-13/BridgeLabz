echo "Hello <<username>>,How are you?"
echo "enter the name you want to replace with username"
read username
if [ ${#username} -ge '3' ];
then
echo "hello $username,How are you?"
else
echo "string is less than minimum characters"
fi
