echo "enter the number:"
read num
a=0
for(( i=1; i<=$num; i++ ))
{
a=$(echo "$i" "$a" |awk '{print $2 + (1/$i)}')
}
echo $a
