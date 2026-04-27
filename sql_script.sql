

CREATE DATABASE HotelManagement;
USE HotelManagement;

CREATE TABLE register (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Hotels (
    hotel_id INT PRIMARY KEY AUTO_INCREMENT,
    hotel_name VARCHAR(250) NOT NULL,
    location VARCHAR(250) NOT NULL,
    contact_info VARCHAR(100) NOT NULL UNIQUE,
    star_rating INT CHECK (star_rating BETWEEN 1 AND 5) 
);

CREATE TABLE Rooms (
    room_id INT PRIMARY KEY AUTO_INCREMENT,
    hotel_id INT NOT NULL,
    room_type ENUM('Single', 'Double', 'Suite', 'Deluxe') NOT NULL,
    price_per_night DECIMAL(10,2) NOT NULL CHECK (price_per_night > 0),
    availability_status BOOLEAN NOT NULL DEFAULT TRUE,
    FOREIGN KEY (hotel_id) REFERENCES Hotels(hotel_id) ON DELETE CASCADE
);

CREATE TABLE Guests (
    guest_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(250) NOT NULL,
    email VARCHAR(150) NOT NULL UNIQUE,
    phone VARCHAR(20) NOT NULL UNIQUE,
    address TEXT NOT NULL
);

CREATE TABLE Bookings (
    booking_id INT PRIMARY KEY AUTO_INCREMENT,
    guest_id INT NOT NULL,
    room_id INT NOT NULL,
    check_in_date DATE NOT NULL,
    check_out_date DATE NOT NULL,
    total_price DECIMAL(10,2) NOT NULL CHECK (total_price >= 0),
    booking_status ENUM('Confirmed', 'Cancelled', 'Completed') NOT NULL DEFAULT 'Confirmed',
    FOREIGN KEY (guest_id) REFERENCES Guests(guest_id) ON DELETE CASCADE,
    FOREIGN KEY (room_id) REFERENCES Rooms(room_id) ON DELETE CASCADE,
    CHECK (check_out_date > check_in_date)
);

CREATE TABLE Payments (
    payment_id INT PRIMARY KEY AUTO_INCREMENT,
    booking_id INT NOT NULL,
    amount DECIMAL(10,2) NOT NULL CHECK (amount >= 0),
    payment_method ENUM('Credit Card', 'Debit Card', 'Cash', 'Online Transfer') NOT NULL,
    payment_status ENUM('Pending', 'Completed', 'Failed') NOT NULL DEFAULT 'Pending',
    FOREIGN KEY (booking_id) REFERENCES Bookings(booking_id) ON DELETE CASCADE
);

CREATE TABLE Services (
    service_id INT PRIMARY KEY AUTO_INCREMENT,
    booking_id INT NOT NULL,
    service_type ENUM('Food', 'Laundry', 'Spa', 'Transport') NOT NULL,
    service_charge DECIMAL(10,2) NOT NULL CHECK (service_charge >= 0),
    FOREIGN KEY (booking_id) REFERENCES Bookings(booking_id) ON DELETE CASCADE
);

CREATE TABLE Staff (
    staff_id INT PRIMARY KEY AUTO_INCREMENT,
    hotel_id INT NOT NULL,
    name VARCHAR(255) NOT NULL,
    role ENUM('Receptionist', 'Manager', 'Housekeeping', 'Chef', 'Waiter') NOT NULL,
    salary DECIMAL(10,2) NOT NULL CHECK (salary >= 1000),
    FOREIGN KEY (hotel_id) REFERENCES Hotels(hotel_id) ON DELETE CASCADE
);

CREATE TABLE guest_profile (
    profile_id INT PRIMARY KEY AUTO_INCREMENT,
    register_id INT NOT NULL,
    name VARCHAR(250) NOT NULL,
    email VARCHAR(150) NOT NULL UNIQUE,
    phone VARCHAR(20) NOT NULL UNIQUE,
    address TEXT NOT NULL,
    FOREIGN KEY (register_id) REFERENCES register(id) ON DELETE CASCADE
);

SELECT * FROM guest_profile WHERE register_id = 1;
SELECT * FROM guest_profile;
SELECT * FROM register;
DELETE FROM register WHERE id = 3;

ALTER TABLE Payments
ADD COLUMN register_id INT NOT NULL,
ADD CONSTRAINT fk_register_id FOREIGN KEY (register_id) REFERENCES register(id) ON DELETE CASCADE;

SELECT * FROM staff;
SELECT * FROM Guests;
ALTER TABLE Guests MODIFY COLUMN register_id INT NULL;
ALTER TABLE Bookings DROP CHECK booking_chk_1;


INSERT INTO Hotels (hotel_name, location, contact_info, star_rating) VALUES
('Grand Royal Hotel', 'Brussels', 'contact@grandroyal.be', 5),
('City Lodge', 'Antwerp', 'info@citylodge.be', 3),
('Seaside Inn', 'Ostend', 'hello@seasideinn.be', 4),
('Mountain View Resort', 'Spa', 'contact@mountainview.be', 4);

-- Grand Royal Hotel (hotel_id = 1)
INSERT INTO Rooms (hotel_id, room_type, price_per_night, availability_status) VALUES
(1, 'Single', 120.00, TRUE),
(1, 'Double', 180.00, TRUE),
(1, 'Suite', 350.00, FALSE),
(1, 'Deluxe', 400.00, TRUE);

-- City Lodge (hotel_id = 2)
INSERT INTO Rooms (hotel_id, room_type, price_per_night, availability_status) VALUES
(2, 'Single', 80.00, TRUE),
(2, 'Double', 130.00, TRUE),
(2, 'Suite', 250.00, TRUE);

-- Seaside Inn (hotel_id = 3)
INSERT INTO Rooms (hotel_id, room_type, price_per_night, availability_status) VALUES
(3, 'Double', 150.00, FALSE),
(3, 'Deluxe', 220.00, TRUE);

-- Mountain View Resort (hotel_id = 4)
INSERT INTO Rooms (hotel_id, room_type, price_per_night, availability_status) VALUES
(4, 'Single', 100.00, TRUE),
(4, 'Suite', 300.00, TRUE),
(4, 'Deluxe', 350.00, FALSE);

-- Insert sample guest users
INSERT INTO register (username, password) VALUES
('anna', 'gp1'),
('mike', 'gp2'),
('sara', 'gp3'),
('omar', 'gp4');

-- Insert sample staff members with passwords
INSERT INTO Staff (hotel_id, name, password, role, salary) VALUES
(1,'Johnson', 'alice123', 'Receptionist', 2000.00),
(1, 'Smith', 'bob123', 'Manager', 3500.00),
(2, 'Diaz', 'carla123', 'Housekeeping', 1500.00),
(1, 'Wu', 'daniel123', 'Chef', 2800.00),
(2, 'Brown', 'ella123', 'Waiter', 1200.00);

-- Insert sample hotels
INSERT INTO Hotels (hotel_name, location, contact_info, star_rating) VALUES
('Sunset Paradise Hotel', 'Brussels, Belgium', 'contact@sunsetparadise.be', 4),
('Ocean Breeze Resort', 'Ostend, Belgium', 'info@oceanbreeze.be', 5);

