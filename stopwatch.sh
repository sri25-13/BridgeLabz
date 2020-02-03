echo -n "enter start time:"
read start
echo -n "enter end time:"
read end
echo "elapsed time :"
echo $((end - start)) | awk '{print int($1%60)}'
