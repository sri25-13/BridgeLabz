echo -n "enter a value:"
read a
echo -n "enter b value:"
read b
echo -n "enter c value:"
read c
delta=$(($((b * b)) - $((4 * a * c))))
echo "delta "$delta
div=`expr 2 \* $a`
x=$(echo "$b" "$div" "$delta" | awk '{print ((((-$1 + sqrt($3))) / (($2))))}')
y=$(echo "$b" "$div" "$delta" | awk '{print ((((-$1 - sqrt($3))) / (($2))))}')
echo $x
echo $y
