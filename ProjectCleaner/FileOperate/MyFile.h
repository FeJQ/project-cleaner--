#pragma once
#include <string>
using namespace std;
class MyFile
{
public:
	MyFile();
	~MyFile();
	//��ȡָ��·���µ������ļ�
	char* getAllFiles(string path);
};

