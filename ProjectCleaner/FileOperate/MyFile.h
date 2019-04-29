#pragma once
#include <string>
using namespace std;
class MyFile
{
public:
	MyFile();
	~MyFile();
	//获取指定路径下的所有文件
	char* getAllFiles(string path);
};

