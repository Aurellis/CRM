CREATE DATABASE  IF NOT EXISTS `crm_base` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `crm_base`;
-- MySQL dump 10.13  Distrib 8.0.24, for Win64 (x86_64)
--
-- Host: localhost    Database: crm_base
-- ------------------------------------------------------
-- Server version	8.0.24

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clients` (
  `id` int NOT NULL AUTO_INCREMENT,
  `surname` varchar(128) DEFAULT NULL,
  `name` varchar(128) DEFAULT NULL,
  `patronymic` varchar(128) DEFAULT NULL,
  `tel` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients`
--

LOCK TABLES `clients` WRITE;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` VALUES (1,'Иванов','Иван','Иванович','89000000000'),(2,'Сидоров','Сидоров','','89000000000'),(3,'Петров','Петров','','89000000000'),(4,'Авакян','Зозо','','89001112233');
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `masters`
--

DROP TABLE IF EXISTS `masters`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `masters` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `FullName` varchar(128) NOT NULL,
  `Point_ID` int DEFAULT NULL,
  `isactive` tinyint DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `masters`
--

LOCK TABLES `masters` WRITE;
/*!40000 ALTER TABLE `masters` DISABLE KEYS */;
INSERT INTO `masters` VALUES (1,'Кожкина','Кожкина Елена',NULL,1);
/*!40000 ALTER TABLE `masters` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `id` int NOT NULL AUTO_INCREMENT,
  `service_id` int NOT NULL,
  `master_id` int NOT NULL,
  `paytype_id` int NOT NULL,
  `reqtype_id` int NOT NULL,
  `user_id` int NOT NULL,
  `client_id` int NOT NULL,
  `datedelivery` datetime DEFAULT NULL,
  `isdone` tinyint DEFAULT NULL,
  `datereg` datetime DEFAULT NULL,
  `datepay` datetime DEFAULT NULL,
  `forpay` float DEFAULT NULL,
  `paysum` float DEFAULT NULL,
  `prim` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,1,1,1,2,1,1,'2021-05-15 10:33:24',0,'2021-05-15 10:33:24','2021-05-15 10:33:24',250.5,0,'примечание'),(2,1,1,1,2,1,2,'2021-05-15 13:52:33',0,'2021-05-15 13:52:33','2021-05-15 13:52:33',250.5,300,''),(3,1,1,1,1,1,3,'2021-05-15 17:15:23',0,'2021-05-15 17:15:23','2021-05-15 17:15:23',250.5,0,'ываываыва'),(4,1,1,1,2,1,4,'2021-05-16 22:49:47',0,'2021-05-16 22:49:47','2021-05-16 22:49:47',250.5,0,'');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paytype`
--

DROP TABLE IF EXISTS `paytype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paytype` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paytype`
--

LOCK TABLES `paytype` WRITE;
/*!40000 ALTER TABLE `paytype` DISABLE KEYS */;
INSERT INTO `paytype` VALUES (1,'Наличная'),(2,'Безналичная');
/*!40000 ALTER TABLE `paytype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `points`
--

DROP TABLE IF EXISTS `points`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `points` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Prim` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `points`
--

LOCK TABLES `points` WRITE;
/*!40000 ALTER TABLE `points` DISABLE KEYS */;
INSERT INTO `points` VALUES (1,'Основная точка','Доп инфо');
/*!40000 ALTER TABLE `points` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `requesttype`
--

DROP TABLE IF EXISTS `requesttype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `requesttype` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requesttype`
--

LOCK TABLES `requesttype` WRITE;
/*!40000 ALTER TABLE `requesttype` DISABLE KEYS */;
INSERT INTO `requesttype` VALUES (1,'Личное'),(2,'Телефонное');
/*!40000 ALTER TABLE `requesttype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Администратор'),(2,'Пользователь');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `services`
--

DROP TABLE IF EXISTS `services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `services` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Price` varchar(45) NOT NULL,
  `Point_ID` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `services`
--

LOCK TABLES `services` WRITE;
/*!40000 ALTER TABLE `services` DISABLE KEYS */;
INSERT INTO `services` VALUES (1,'стрижка','250,5',1);
/*!40000 ALTER TABLE `services` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Login` varchar(15) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `UserName` varchar(128) NOT NULL,
  `FullName` varchar(128) DEFAULT NULL,
  `Role_Id` int NOT NULL,
  `Point_Id` int NOT NULL,
  `isactive` tinyint DEFAULT '1',
  PRIMARY KEY (`id`),
  UNIQUE KEY `Login_UNIQUE` (`Login`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','1234','Администратор','Администратор',1,1,1),(2,'user','123','Пользователь','Пользователь',2,1,1);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'crm_base'
--

--
-- Dumping routines for database 'crm_base'
--
/*!50003 DROP PROCEDURE IF EXISTS `addcard` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `addcard`(
			in vsurname varchar(128), 
               vname varchar(128), 
               vpatronymic varchar(128), 
               vtel varchar(20), 
               vmaster varchar(128), 
               vservice varchar(128),
               vplandat datetime,
               vuser varchar(128),
               vtypereg varchar(128),
               visdone boolean,
               vdatereg datetime,
               vsumtopay float,
               vsumpay float,
               vdatepay datetime,
               vpaytype varchar(128),
               vprim varchar(256),
               vpoint_id int)
BEGIN
declare service_id int;
declare master_id  int;
declare paytype_id int;
declare reqtype_id int;
declare user_id int;
declare plandat datetime;
declare regdat datetime;
declare paydat datetime;

set service_id = (select id from services     where name like concat('', vservice,''));
set master_id  = (select id from masters      where name like concat('', vmaster,''));
set paytype_id = (select id from paytype      where name like concat('', vpaytype,'')); 
set reqtype_id = (select id from requesttype  where name like concat('', vtypereg,''));
set user_id    = (select id from users        where username like concat('', vuser,''));
set plandat = (select replace(vplandat,'.','-'));
set regdat = (select replace(vdatereg,'.','-'));
set paydat = (select replace(vdatepay,'.','-'));

call addclient(vsurname, vname, vpatronymic, vtel, @client_id);

INSERT INTO orders (service_id, master_id, paytype_id, reqtype_id, 
                    user_id, client_id, datedelivery, isdone, datereg, 
                    datepay, forpay, paysum , prim)
select service_id, master_id, paytype_id, reqtype_id, 
	    user_id, @client_id, plandat, visdone,regdat ,
        paydat , vsumtopay, vsumpay, vprim;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AddClient` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddClient`(in sname varchar(128), cname varchar(128), patron varchar(128),telephone varchar(20), out client_id int)
BEGIN

if  not exists(select * from clients where surname = sname and name = cname and patronymic = patron) then
	insert into clients (surname,name,patronymic,tel)
		select sname, cname, patron, telephone;
        
	set client_id = (select id  from clients where surname = sname and name = cname and patronymic = patron);    
else
	set client_id = (select id  from clients where surname = sname and name = cname and patronymic = patron);  
end if;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `additemlist` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `additemlist`(target varchar(128), 
                                vname varchar(128), 
                                vfullname varchar(128), 
                                vpatron varchar(128), 
                                vtel varchar(128), 
                                vtpoint varchar(128), 
                                visactive bool, 
                                vurole varchar(128) )
BEGIN
declare point_id int;
declare role_id int;

set point_id = (select id from points where name like concat('',vtpoint,''));
set role_id = (select id from roles where name like concat('',vurole,''));

if(target = 'master') then
	INSERT INTO masters(Name, FullName, Point_ID, isactive)
    select vname, vfullname, point_id, visactive;
end if;

if(target = 'client') then
	INSERT INTO clients(surname, name, patronymic, tel)
	select vname, vfullname, vpatron, vtel;
end if;

if(target = 'point') then
INSERT INTO points(Name, Prim)
select vname, vfullname;
end if;

if(target = 'user') then
INSERT INTO users (Login, Password, UserName, FullName, Point_Id, Role_Id, isactive)
			   select vname, vfullname, vpatron, vtel, point_id, role_id, visactive;
end if;

if(target = 'role') then
	INSERT INTO roles(name)
	select vname;
end if;

if(target = 'service') then
	INSERT INTO services(Name, Price, Point_ID)
	select vname, vfullname, point_id;
end if;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `edititem` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `edititem`(target varchar(128),
target_id int,
vname varchar(128),
vfullname varchar(128),
vpatron varchar(128),
vtel varchar(128),
vtpoint varchar(128),
visactive bool,
vurole varchar(128) )
BEGIN

declare point_id int;
declare role_id int;

if(target = 'master') then
set point_id = (select id from points where name like concat('',vtpoint,'') );
UPDATE masters
SET
Name = vname,
FullName = vfullname,
Point_ID = point_id,
isactive = visactive
WHERE `id` = target_id;
end if;

if(target = 'client') then
UPDATE clients
SET
surname = vname,
name = vfullname,
patronymic = vpatron,
tel = vtel
WHERE id = target_id;
end if;

if(target = 'points') then
UPDATE points
SET
Name = vname,
Prim = vfullname
WHERE id = target_id;
end if;

if(target = 'users') then
set role_id = (select id from roles where name like concat('',vurole,''));
set point_id = (select id from points where name like concat('',vtpoint,''));
UPDATE users
SET
Login = vname,
Password = vfullname,
UserName = vpatron,
FullName = vtel,
Role_Id = role_id,
Point_Id = point_id,
isactive = visactive
WHERE id = target_id;
end if;

if(target = 'role') then
UPDATE roles
SET
Name = vname
WHERE id = target_id;
end if;

if(target = 'service') then
set point_id = (select id from points where name like concat('',vtpoint,''));
UPDATE services
SET
Name = vname,
Price = vfullname,
Point_ID = point_id
WHERE id = target_id;

end if;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getcard` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getcard`(card_id int)
BEGIN
if (card_id <> 0) then
SELECT orders.id, 
       services.name as service, 
       masters.name as master, 
       paytype.name as paytype, 
       requesttype.name as requesttype, 
       users.username as user, 
       clients.surname as family, 
       clients.name as clientname, 
       clients.patronymic as patron, 
       clients.tel as tel, 
       orders.datedelivery, 
       orders.isdone, 
       orders.datereg, 
       orders.datepay, 
       orders.forpay, 
       orders.paysum, 
       orders.prim
FROM orders
left join services on services.id = orders.service_id
left join masters on masters.id = orders.master_id
left join paytype on paytype.id = orders.paytype_id
left join requesttype on requesttype.id = orders.reqtype_id
left join users on users.id = orders.user_id
left join clients on clients.id = orders.client_id
where orders.id = card_id;
else
SELECT orders.id, 
       services.name as service, 
       masters.name as master, 
       paytype.name as paytype, 
       requesttype.name as requesttype, 
       users.username as user, 
       clients.surname as family, 
       clients.name as clientname, 
       clients.patronymic as patron, 
       clients.tel as tel, 
       orders.datedelivery, 
       orders.isdone, 
       orders.datereg, 
       orders.datepay, 
       orders.forpay, 
       orders.paysum, 
       orders.prim
FROM orders
left join services on services.id = orders.service_id
left join masters on masters.id = orders.master_id
left join paytype on paytype.id = orders.paytype_id
left join requesttype on requesttype.id = orders.reqtype_id
left join users on users.id = orders.user_id
left join clients on clients.id = orders.client_id;
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getitem` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getitem`(target varchar(128), target_id int)
BEGIN

if(target = 'master') then
	select * from masters where id = target_id;
end if;
if(target = 'client') then
	select * from clients where id = target_id;
end if;
if(target = 'point') then
	select * from points where id = target_id;
end if;
if(target = 'role') then
	select * from roles where id = target_id;
end if;
if(target = 'service') then
	select * from services where id = target_id;
end if;
if(target = 'user') then
	select * from users where id = target_id;
end if;
if(target = 'card') then
	call getcard(target_id);
end if;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getlist` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getlist`(target varchar(128))
BEGIN

if(target = 'master') then
	select * from masters;
end if;
if(target = 'client') then
	select * from clients;
end if;
if(target = 'point') then
	select * from points;
end if;
if(target = 'role') then
	select * from roles;
end if;
if(target = 'service') then
	select * from services;
end if;
if(target = 'user') then
	select users.id, login, username, fullname, points.name as points, roles.name as roles, isactive
    from users
    left join points on points.id = users.point_id
    left join roles on roles.id = users.role_id;
end if;
if(target = 'card') then
	call getcard(0);
end if;
if(target = 'reqtype') then
	select * from requesttype;
end if;
if(target = 'paytype') then
	select * from paytype;
end if;


END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `updatecard` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `updatecard`(in vsurname varchar(128), 
               vname varchar(128), 
               vpatronymic varchar(128), 
               vtel varchar(20), 
               vmaster varchar(128), 
               vservice varchar(128),
               vplandat datetime,
               vuser varchar(128),
               vtypereg varchar(128),
               visdone boolean,
               vdatereg datetime,
               vsumtopay float,
               vsumpay float,
               vdatepay datetime,
               vpaytype varchar(128),
               vprim varchar(256),
               vpoint_id int,
               cardid int)
BEGIN

declare service_id int;
declare master_id  int;
declare paytype_id int;
declare reqtype_id int;
declare user_id int;
declare plandat datetime;
declare regdat datetime;
declare paydat datetime;

set service_id = (select id from services     where name     = vservice);
set master_id  = (select id from masters      where name     = vmaster);
set paytype_id = (select id from paytype      where name     = vpaytype); 
set reqtype_id = (select id from requesttype  where name     = vtypereg);
set user_id    = (select id from users        where username = vuser);
set plandat = (select replace(vplandat,'.','-'));
set regdat = (select replace(vdatereg,'.','-'));
set paydat = (select replace(vdatepay,'.','-'));

call addclient(vsurname, vname, vpatronymic, vtel, @client_id);

UPDATE `crm_base`.`orders`
SET
`service_id` = service_id,
`master_id` = master_id,
`paytype_id` = paytype_id,
`reqtype_id` = reqtype_id,
`user_id` = user_id,
`client_id` =  @client_id,
`datedelivery` = plandat,
`isdone` = visdone,
`datereg` = regdat,
`datepay` = paydat,
`forpay` = vsumtopay,
`paysum` = vsumpay,
`prim` = vprim
WHERE `id` = cardid;


END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-05-16 23:31:00
