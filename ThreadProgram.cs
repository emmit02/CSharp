using System;
using System.Threading;

class ThreadProgram
{
    static void CalculateFactorial(object num)
    {
        int n = (int)num;
        long result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
            Console.WriteLine($"Factorial calculation at step {i}: {result}");
            Thread.Sleep(1000);  
        }

        Console.WriteLine($"\nFactorial of {n} is: {result}");
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number to calculate its factorial: ");
        int number = int.Parse(Console.ReadLine());

        Thread factorialThread = new Thread(CalculateFactorial);
        factorialThread.Start(number);
        factorialThread.Join();

        Console.WriteLine("Factorial calculation is complete.");
    }
}
















































#include <pthread.h>
#include <stdio.h>
 
pthread_mutex_t buffer_mutex = PTHREAD_MUTEX_INITIALIZER; // Static initialization of mutex
pthread_cond_t data_available = PTHREAD_COND_INITIALIZER; // Static initialization of condition variable
 
int shared_data = 0;
int data_ready = 0;
 
void* producer(void* arg) {
    pthread_mutex_lock(&buffer_mutex);
    // Produce some data
    shared_data = 42;
    data_ready = 1;
 
    // Signal the consumer that data is available
    pthread_cond_signal(&data_available);
 
    pthread_mutex_unlock(&buffer_mutex);
    return NULL;
}
 
void* consumer(void* arg) {
    pthread_mutex_lock(&buffer_mutex);
    // Wait for the data to be available
    while (!data_ready) {
        pthread_cond_wait(&data_available, &buffer_mutex);
    }
 
    // Now the data is available, we can consume it
    printf("Consumed data: %d\n", shared_data);
 
    pthread_mutex_unlock(&buffer_mutex);
    return NULL;
}
 
int main() {
    pthread_t prod_thread, cons_thread;
 
    // Create producer and consumer threads
    pthread_create(&prod_thread, NULL, producer, NULL);
    pthread_create(&cons_thread, NULL, consumer, NULL);
 
    // Wait for threads to finish
    pthread_join(prod_thread, NULL);
    pthread_join(cons_thread, NULL);
 
    return 0;
}