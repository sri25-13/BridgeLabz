echo -n "enter the value:"
read x
echo -n "enter another value:"
read y
a=`expr $x \* $x`
b=`expr $y \* $y`
c=`expr $a + $b`
tot=`echo - | awk '{print sqrt('$c')}'`
echo $tot
