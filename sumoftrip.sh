echo -n "enter the array size:" 
read n
declare -A arr[$n]
for (( i=0; i<$n; i++ ))
do
echo "enter the array elements:"
read arr[$i]
done
for (( i=0; i<$n-2; i++ ));
do
for (( j=i+1; j<$n-1; j++ ));
do
for (( k=j+1; k<$n; k++ ));
do
sum=$(( arr[$i] + arr[$j] +arr[$k] ))
if [ $sum -eq 0 ]
then
echo "${arr[$i]} ${arr[$j]} ${arr[$k]}"
fi
done
done
done
