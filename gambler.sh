echo "enter the stake:"
read stake
echo "enter the goal:"
read goal
echo "enter how many times  u wanna trial:"
read trail
bets=1
wins=1
for (( t=1; t<=$trail; t++ ))
do
 cash=$stake
  while [[ $cash > 0 && $cash < $goal ]]
  do
    bets=$(( $bets + 1 ))
     if [[ $(( 1 + $RANDOM % 2 )) -lt 5 ]]
     then
       cash=$cash++
     else
       cash=$$cash--
     fi
done
if [ $cash -eq $goal ]
then
	wins=$wins++
 fi
done
winper=$(echo "$trials" "$wins" | awk '{print 100*$(($trials/$wins))}')
lossper=`expr 100 - $winper`
echo "win percentage is $winper"
echo "loss percentage is $lossper"
