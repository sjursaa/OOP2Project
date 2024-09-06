if exists (select name
from sysobjects
where name = 'GetSensorData'
and type = 'V')
drop view GetSensorData
go


create view GetSensorData
as

SELECT 
Sensor.SensorID,
Sensor.Name,
SensorType.SensorTypeID,
SensorType.TypeName,
GeoLocation.LocationID,
GeoLocation.City

from Sensor
Inner join SensorType on Sensor.SensorID = SensorType.SensorTypeID
Inner join GeoLocation on Sensor.LocationID = GeoLocation.LocationID

go
