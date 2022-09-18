Console.Write("Укажите к какому другу бежит собака:  ");
double friend = Convert.ToInt32(Console.ReadLine());
double dist = 100;
double first_friend_speed = 1;
double second_friend_speed = 2;
double dog_speed = 5;
double count = 0;
double time = 0;


while(dist > 10)
{
    if(friend == 1)
    {
        time = dist/(first_friend_speed + dog_speed);
        
        
    }
    else
    {
        time = dist/(second_friend_speed + dog_speed);
        
        
    }

    dist = dist - (first_friend_speed + second_friend_speed) * time;

    count++;
 }
Console.WriteLine($"Сколько раз пробежит собака - {count}");