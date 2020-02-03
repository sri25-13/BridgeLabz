echo "Enter the Number"
read num
 power=1
if [ 0 -le $num ] && [ $num -lt 31 ]
then
for ((i=0;i<=$num;i++))
do
echo "2^" $i "=" $power
power=`expr $power \* 2`
done
else
echo "Invalid Input"
fi
