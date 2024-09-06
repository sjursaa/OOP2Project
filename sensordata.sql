-- reverse from create section
DROP TABLE IF EXISTS Credential;
DROP TABLE IF EXISTS Account;
DROP TABLE IF EXISTS SensorData;
DROP TABLE IF EXISTS Sensor;
DROP TABLE IF EXISTS GeoLocation;
DROP TABLE IF EXISTS Place;
DROP TABLE IF EXISTS Location;
DROP TABLE IF EXISTS SensorType;

-- create tables
CREATE TABLE SensorType (
    SensorTypeID INT IDENTITY(1,1) PRIMARY KEY,
    TypeName VARCHAR(50) NOT NULL,
    -- is simulate attribute mabye
);

CREATE TABLE GeoLocation (
    LocationID INT IDENTITY(1,1) PRIMARY KEY,
    City VARCHAR(50) NOT NULL,
    Zipcode INT NOT NULL,
);

CREATE TABLE Sensor (
    SensorID INT IDENTITY(1,1) PRIMARY KEY,
    SensorTypeID INT FOREIGN KEY REFERENCES SensorType(SensorTypeID),
    Name VARCHAR(50) NOT NULL,
    LocationID INT FOREIGN KEY REFERENCES GeoLocation(LocationID),
);

CREATE TABLE SensorData (
    SensorDataID INT IDENTITY(1,1) PRIMARY KEY,
    SensorID INT FOREIGN KEY REFERENCES Sensor(SensorID),
    Timestamp DATETIME NOT NULL,
    Value FLOAT NOT NULL,
);

-- User er reservert
CREATE TABLE Account (
    AccountID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    LocationID INT FOREIGN KEY REFERENCES GeoLocation(LocationID),
);

CREATE TABLE Credential (
    CredentialID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL, 
    Password VARCHAR(100) NOT NULL,
    AccountID INT FOREIGN KEY REFERENCES Account(AccountID),
);

-- Insert eksempeldata

-- Sample data for SensorType table
INSERT INTO SensorType (TypeName)
VALUES
    ('Temperature'),
    ('Humidity'),
    ('Pressure');

-- Eksempeldata for locasion
INSERT INTO GeoLocation (City, Zipcode)
VALUES
    ('Porsgrunn', 1202),
    ('Oslo', 1933),
    ('Trondheim', 3913);
    
-- Sample data for Sensor table
INSERT INTO Sensor (SensorTypeID, Name, LocationID)
VALUES
    (1, 'Temperature Real', 1),
    (2, 'Humidity Sensor B', 2),
    (1, 'Temperature Sensor Sim A', 2),
    (3, 'Pressure Sensor C', 1),
    (3, 'Pressure sensor D', 1);

-- Sample data for SensorData table
INSERT INTO SensorData (SensorID, Timestamp, Value)
VALUES
    (1, '2023-11-01 08:00:00', 25.5),
    (1, '2023-11-01 08:01:00', 25.6),
    (1, '2023-11-01 08:02:00', 26.9),
    (1, '2023-11-01 08:03:00', 25.6),
    (1, '2023-11-01 08:04:00', 24.0),
    (3, '2023-11-01 08:00:02', 1010.2),
    (1, '2023-11-01 09:00:03', 26.0),
    (3, '2023-11-01 09:00:05', 1011.1);

