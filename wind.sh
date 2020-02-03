echo -n "enter t value:"
read t
echo -n "enter v value:"
read v
if [ $t -le 50 ]
then
if [ $v -le 120 -a $v -ge 3 ]
then
w=$(echo "$t" "$v" | awk '{print (35.74 + 0.6215 * $1) - ((0.4275 * $1)-35.75) * ($2^0.16)}')
echo $w   
else
echo " invalid input"
fi
fi
