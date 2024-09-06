-- Drop if exists
if exists(select name from
sysobjects where name = 'DeleteSensor' and type = 'P')
drop procedure DeleteSensor
go

if exists(select name from
sysobjects where name = 'InsertSensorData' and type = 'P')
drop procedure InsertSensorData
go

-- Create Procedurs 
create procedure DeleteSensor
@SensorID int
as

delete from SensorData where SensorID = @SensorID
delete from Sensor where SensorID = @SensorID

go


create procedure InsertSensorData
@Timestamp datetime,
@Value float
as

insert into SensorData (SensorID, Timestamp, Value)
values (1, @Timestamp, @Value);
