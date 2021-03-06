﻿using CityInfo.API.Entities;
using System.Collections.Generic;

namespace CityInfo.API.Services
{
    public interface ICityInfoRepository
    {
        bool CityExists(int cityId);

        IEnumerable<City> GetCities();

        City GetCity(int cityId, bool includePointsOfInterest);
        
        // one
        PointOfInterest GetPointOfInterestForCity(int CityId, int pointOfInterestId);

        // many
        IEnumerable<PointOfInterest> GetPointsOfInterestForCity(int CityId);

        void AddPointOfInterestForCity(int cityId, PointOfInterest pointOfInterest);

        void DeletePointOfInterest(PointOfInterest pointOfInterest);

        bool Save();
    }
}
