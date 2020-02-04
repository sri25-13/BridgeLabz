echo "enter the stake:"
read stake
echo "enter the goal:"
read goal
echo "enter how many times  u wanna trial:"
read trials
bets=0
wins=0
for((t=1; t<$trials; t++))
do
bets=$(($bets + 1 ))
  while [[ $stake > 0 && $stake < $goal ]]
  do
     if [[ cash -lt 100 ]]
     then
       stake=$(( $stake + 1 ))
     else
       stake=$(( $stake - 1 ))
     fi
if [ $stake == $goal ]
then 
	wins=$(( $wins + 1 ))
 fi
done
done
echo $wins "wins of" $trials
winpercentage= $(($((100*$wins))/$trials))
echo "win percentage is =" $(($((100*$wins))/$trials))
#echo "loss percentage is =" $((100-$winpercentage))


