echo  "enter the value for row:"
read m
echo  "enter the value for column:"
read n
echo  "give the array elements"
echo
for (( i=1; i<=$m; i++ ))
do
for (( j=1; j<=$n; j++ ))
do
read array[$i,$j]
done 
done
for((i=1; i<=$m; i++))
do
for((j=1;j<=$n; j++))
do
echo  -e ${array[$i,$j]} '\c'
done
echo
done

