echo "enter the stake:"
read stake
echo "enter the goal:"
read goal
echo "enter how many times  u wanna trial:"
<<<<<<< HEAD
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
=======
read trials
bets=0
wins=0
for (( t=0; t<$trials; t++ ))
do
  while [[ $stake > 0 && $stake < $goal ]]
  do
     if [[ cash -lt 100 ]]
     then
       stake=$(($stake+1))
     else
       stake=$(($stake-1))
     fi
done
if [ $stake == $goal ]
then
	wins=$(($wins+1))
 fi
done
echo $wins "wins of" $trials
echo "win percentage is =" $(($((100*$wins))/$trials))
#echo "loss percentage is $losspe"

>>>>>>> [harshini]add .Implementation of gambler shellscript program
