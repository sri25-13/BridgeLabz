echo "enter a number:"
read n
declare -i headco=0
declare -i tailco=0
count=1
for((i=0; i<=$n; i++))
{
rnd=$((1 + RANDOM%10))
if [ $rnd -lt 5 ]
then
headco=$headco+$count
else
tailco=$tailco+$count
fi
}
add=`expr $add + 1`
declare -i h=$headco*100/$n
declare -i t=$tailco*100/$n
echo "heads :" $h%
echo "tails :" $t%
