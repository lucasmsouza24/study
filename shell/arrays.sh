FRUITS=("bananna" "apple" "orange" "strawberry" "pineapple" "watermelon")

LEN=${#FRUITS[@]}

clear 

printSleep() {

    # checking if -c (clear) exists
    if [[ $* == *-c* ]];
    then 
        clear
    fi 

    # printing message and sleeping
    echo $1
    sleep $2
}

printSleep "criando arquivo" 1 -c
printSleep "criando arquivo." 1 -c
printSleep "criando arquivo.." 1 -c 
printSleep "criando arquivo..." 1 -c
echo ""

touch ./fruits.txt

for INDEX in $(seq 0 $(($LEN - 1))); do 
    sleep 1
    POS=$(($INDEX + 1))
    echo "fruta ${POS}: ${FRUITS[$INDEX]}"
    echo "fruta ${POS}: ${FRUITS[$INDEX]}" >> ./fruits.txt
done

echo ""
echo "lendo arquivo"
echo ""

cat ./fruits.txt