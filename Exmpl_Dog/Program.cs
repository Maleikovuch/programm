Console.WriteLine("Укажиет к какому другу бежит собака");
int friend = Convert.ToInt32(Console.ReadLine());
int dist = 100;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_speed = 5;
int count = 0;
int time = 0;


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
Console.WriteLine($"Сколько раз пробежит собака = {count}");