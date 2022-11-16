/*
 Navicat Premium Data Transfer

 Source Server         : SalarySys
 Source Server Type    : SQLite
 Source Server Version : 3035005
 Source Schema         : main

 Target Server Type    : SQLite
 Target Server Version : 3035005
 File Encoding         : 65001

 Date: 09/11/2022 20:04:28
*/

PRAGMA foreign_keys = false;

-- ----------------------------
-- Table structure for Department
-- ----------------------------
DROP TABLE IF EXISTS "Department";
CREATE TABLE "Department" (
  "id" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
  "name" TEXT NOT NULL,
  "depart_no" integer NOT NULL
);

-- ----------------------------
-- Records of Department
-- ----------------------------

-- ----------------------------
-- Table structure for Employee
-- ----------------------------
DROP TABLE IF EXISTS "Employee";
CREATE TABLE "Employee" (
  "id" INTEGER NOT NULL,
  "emp_no" INTEGER NOT NULL,
  "name" TEXT NOT NULL,
  "sex" TEXT NOT NULL,
  "age" INTEGER NOT NULL,
  "entry_date" DATE NOT NULL,
  "position" TEXT NOT NULL,
  "rank" integer NOT NULL DEFAULT 1,
  PRIMARY KEY ("id")
);

-- ----------------------------
-- Records of Employee
-- ----------------------------

-- ----------------------------
-- Table structure for User
-- ----------------------------
DROP TABLE IF EXISTS "User";
CREATE TABLE "User" (
  "id" integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  "user_name" TEXT NOT NULL,
  "password" TEXT NOT NULL,
  "permission" text NOT NULL DEFAULT Visitor
);

-- ----------------------------
-- Records of User
-- ----------------------------
INSERT INTO "User" VALUES (1, 'admin', 'admin', 'admin');

-- ----------------------------
-- Table structure for WorkRecord
-- ----------------------------
DROP TABLE IF EXISTS "WorkRecord";
CREATE TABLE "WorkRecord" (
  "id" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
  "emp_id" INTEGER NOT NULL,
  "clock_in_time" DATE,
  "clock_off_time" DATE,
  "quantity" integer NOT NULL DEFAULT 0
);

-- ----------------------------
-- Records of WorkRecord
-- ----------------------------

-- ----------------------------
-- Table structure for sqlite_sequence
-- ----------------------------
DROP TABLE IF EXISTS "sqlite_sequence";
CREATE TABLE "sqlite_sequence" (
  "name",
  "seq"
);

-- ----------------------------
-- Records of sqlite_sequence
-- ----------------------------
INSERT INTO "sqlite_sequence" VALUES ('User', 1);
INSERT INTO "sqlite_sequence" VALUES ('Department', 0);

-- ----------------------------
-- Auto increment value for Department
-- ----------------------------

-- ----------------------------
-- Auto increment value for User
-- ----------------------------
UPDATE "sqlite_sequence" SET seq = 1 WHERE name = 'User';

PRAGMA foreign_keys = true;
