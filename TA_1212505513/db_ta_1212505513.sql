# Host: localhost  (Version: 5.5.25a)
# Date: 2016-10-27 20:10:42
# Generator: MySQL-Front 5.3  (Build 4.271)

/*!40101 SET NAMES latin1 */;

#
# Structure for table "barang"
#

DROP TABLE IF EXISTS `barang`;
CREATE TABLE `barang` (
  `kd_brg` varchar(5) NOT NULL DEFAULT '',
  `nm_brg` varchar(35) DEFAULT NULL,
  `jnsbrg` varchar(10) DEFAULT NULL,
  `hrgbrg` int(2) DEFAULT NULL,
  `stok` int(2) DEFAULT NULL,
  PRIMARY KEY (`kd_brg`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "barang"
#

/*!40000 ALTER TABLE `barang` DISABLE KEYS */;
INSERT INTO `barang` VALUES ('B0001','aaa','ran',10000,10),('B0002','qwqw','tali',10000,20);
/*!40000 ALTER TABLE `barang` ENABLE KEYS */;

#
# Structure for table "customer"
#

DROP TABLE IF EXISTS `customer`;
CREATE TABLE `customer` (
  `kd_cus` varchar(5) NOT NULL DEFAULT '',
  `nm_cus` varchar(35) DEFAULT NULL,
  `tlpcus` varchar(12) DEFAULT NULL,
  `almtcus` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`kd_cus`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "customer"
#

/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES ('C0001','qwqwwqqw','2121121','wqwqwqwqw'),('C0002','sdadada','4232323','aasasas');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;

#
# Structure for table "detil_retur"
#

DROP TABLE IF EXISTS `detil_retur`;
CREATE TABLE `detil_retur` (
  `no_ret` varchar(6) NOT NULL DEFAULT '',
  `kd_brg` varchar(5) NOT NULL DEFAULT '',
  `no` int(2) DEFAULT NULL,
  `jmlret` int(2) DEFAULT NULL,
  `ket` varchar(50) DEFAULT NULL,
  `jnsganti` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`no_ret`,`kd_brg`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "detil_retur"
#

/*!40000 ALTER TABLE `detil_retur` DISABLE KEYS */;
/*!40000 ALTER TABLE `detil_retur` ENABLE KEYS */;

#
# Structure for table "detil_sj"
#

DROP TABLE IF EXISTS `detil_sj`;
CREATE TABLE `detil_sj` (
  `no_sj` varchar(7) NOT NULL DEFAULT '',
  `kd_brg` varchar(5) NOT NULL DEFAULT '',
  `jmlkrm` int(2) DEFAULT NULL,
  PRIMARY KEY (`no_sj`,`kd_brg`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "detil_sj"
#

/*!40000 ALTER TABLE `detil_sj` DISABLE KEYS */;
/*!40000 ALTER TABLE `detil_sj` ENABLE KEYS */;

#
# Structure for table "detil_sp"
#

DROP TABLE IF EXISTS `detil_sp`;
CREATE TABLE `detil_sp` (
  `no_sp` varchar(7) NOT NULL DEFAULT '',
  `kd_brg` varchar(5) NOT NULL DEFAULT '',
  `jmlsp` int(2) DEFAULT NULL,
  `hrgsp` int(2) DEFAULT NULL,
  PRIMARY KEY (`no_sp`,`kd_brg`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "detil_sp"
#

/*!40000 ALTER TABLE `detil_sp` DISABLE KEYS */;
INSERT INTO `detil_sp` VALUES ('SP00004','B0001',2,10000),('SP00004','B0002',2,10000),('SP00004','B0003',2,10000),('SP00005','B0002',2,10000);
/*!40000 ALTER TABLE `detil_sp` ENABLE KEYS */;

#
# Structure for table "kurir"
#

DROP TABLE IF EXISTS `kurir`;
CREATE TABLE `kurir` (
  `kd_kur` varchar(3) NOT NULL DEFAULT '',
  `nm_kur` varchar(35) DEFAULT NULL,
  `tlpkur` varchar(12) DEFAULT NULL,
  `almtkur` varchar(55) DEFAULT NULL,
  PRIMARY KEY (`kd_kur`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "kurir"
#

/*!40000 ALTER TABLE `kurir` DISABLE KEYS */;
INSERT INTO `kurir` VALUES ('K02','qweqeq','323232','2232323'),('K03','qqeq','223','qwqwq'),('K04','qwqwqw','212121','asasada');
/*!40000 ALTER TABLE `kurir` ENABLE KEYS */;

#
# Structure for table "kwitansi"
#

DROP TABLE IF EXISTS `kwitansi`;
CREATE TABLE `kwitansi` (
  `no_kwit` varchar(7) NOT NULL DEFAULT '',
  `tglkwit` date DEFAULT NULL,
  `no_nota` varchar(7) NOT NULL DEFAULT '',
  PRIMARY KEY (`no_kwit`,`no_nota`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "kwitansi"
#

/*!40000 ALTER TABLE `kwitansi` DISABLE KEYS */;
/*!40000 ALTER TABLE `kwitansi` ENABLE KEYS */;

#
# Structure for table "nota"
#

DROP TABLE IF EXISTS `nota`;
CREATE TABLE `nota` (
  `no_nota` varchar(7) NOT NULL DEFAULT '',
  `tglnota` date DEFAULT NULL,
  `dp` int(2) DEFAULT NULL,
  `jnsbyr` varchar(5) DEFAULT NULL,
  `no_sp` varchar(7) NOT NULL DEFAULT '',
  PRIMARY KEY (`no_nota`,`no_sp`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "nota"
#

/*!40000 ALTER TABLE `nota` DISABLE KEYS */;
/*!40000 ALTER TABLE `nota` ENABLE KEYS */;

#
# Structure for table "retur"
#

DROP TABLE IF EXISTS `retur`;
CREATE TABLE `retur` (
  `no_ret` varchar(7) NOT NULL DEFAULT '',
  `tglret` date DEFAULT NULL,
  `no_sj` varchar(7) NOT NULL DEFAULT '',
  PRIMARY KEY (`no_ret`,`no_sj`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "retur"
#

/*!40000 ALTER TABLE `retur` DISABLE KEYS */;
/*!40000 ALTER TABLE `retur` ENABLE KEYS */;

#
# Structure for table "sj"
#

DROP TABLE IF EXISTS `sj`;
CREATE TABLE `sj` (
  `no_sj` varchar(7) NOT NULL DEFAULT '',
  `tglsj` date DEFAULT NULL,
  `no_kwit` varchar(7) NOT NULL DEFAULT '',
  `kd_kur` varchar(3) NOT NULL DEFAULT '',
  PRIMARY KEY (`no_sj`,`kd_kur`,`no_kwit`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "sj"
#

/*!40000 ALTER TABLE `sj` DISABLE KEYS */;
/*!40000 ALTER TABLE `sj` ENABLE KEYS */;

#
# Structure for table "sp"
#

DROP TABLE IF EXISTS `sp`;
CREATE TABLE `sp` (
  `no_sp` varchar(7) NOT NULL DEFAULT '',
  `tglsp` date DEFAULT NULL,
  `kd_cus` varchar(5) NOT NULL DEFAULT '',
  `almtkrm` varchar(55) DEFAULT NULL,
  `tgl_krm` date DEFAULT NULL,
  PRIMARY KEY (`no_sp`,`kd_cus`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "sp"
#

/*!40000 ALTER TABLE `sp` DISABLE KEYS */;
INSERT INTO `sp` VALUES ('SP00004','2016-10-27','C0001','qweqewqeq','2016-10-27'),('SP00005','2016-10-27','C0001','jakarta','2016-10-27');
/*!40000 ALTER TABLE `sp` ENABLE KEYS */;
