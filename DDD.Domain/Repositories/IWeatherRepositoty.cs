using DDD.Domain.Entities;

namespace DDD.Domain.Repositories
{
    public interface IWeatherRepositoty
    {
        WeatherEntity SearchLatest(int areaId);
    }
}
