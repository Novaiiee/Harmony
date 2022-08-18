using Harmony.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Harmony.Infrastructure;

public static class Seed
{
    private static readonly List<string> Moods = new() { "Terrible", "Bad", "Okay", "Good", "Awesome" };

    private static readonly List<string> Feelings = new() { "Happy", "Blessed", "Good", "Confused", "Bored", "Awkward", "Angry", "Anxious", "Down", "Stressed" };

    private static readonly List<string> Activities = new() { "Being With Family", "Friends", "Going on a Date", "Being with Friends", "Exercising", "Sports", "Relaxing", "Watching Movies", "Reading", "Gaming", "Cleaning", "Shopping", "Eating Healthy" };

    public static void Create(ModelBuilder builder)
    {
        CreateMoods(builder);
        CreateActivities(builder);
        CreateFeelings(builder);
    }

    private static void CreateMoods(ModelBuilder builder)
    {
        foreach (string mood in Moods)
        {
            builder.Entity<Mood>().HasData(new Mood { Name = mood, Id = Guid.NewGuid().ToString() });
        }
    }

    private static void CreateFeelings(ModelBuilder builder)
    {
        foreach (string feeling in Feelings)
        {
            builder.Entity<Feeling>().HasData(new Feeling { Name = feeling, Id = Guid.NewGuid().ToString() });
        }
    }

    private static void CreateActivities(ModelBuilder builder)
    {
        foreach (string activity in Activities)
        {
            builder.Entity<Activity>().HasData(new Activity { Name = activity, Id = Guid.NewGuid().ToString() });
        }
    }
}