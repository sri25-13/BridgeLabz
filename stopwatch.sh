echo -n "enter start time:"
read start
echo -n "enter end time:"
read end
echo -n  "elapsed time in seconds :"
echo $((end - start)) | awk '{print int($1%60)}'
