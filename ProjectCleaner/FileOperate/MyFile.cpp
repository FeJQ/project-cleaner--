#include "MyFile.h"
#include <vector>
#include <io.h>
#include <fstream>


MyFile::MyFile()
{
}


MyFile::~MyFile()
{
}


//�ļ�·���б�
vector<string> files;

/// <summary>
/// ��ȡָ��·���µ������ļ�
/// </summary>
/// <param name="path">ָ��·��</param>
/// <param name="list">�ļ��б�</param>
/// <return>���ɹ�,���������ļ�����·��(��|����)</return>
char* MyFile::getAllFiles(string path)
{	
	//�ļ����
	long hFile = 0;
	//�ļ���Ϣ
	struct _finddata_t fileinfo;  //�����õ��ļ���Ϣ��ȡ�ṹ
	string p;  //string�������˼��һ����ֵ����:assign()���кܶ����ذ汾
	if ((hFile = _findfirst(p.assign(path).append("\\*").c_str(), &fileinfo)) != -1) {
		do {
			if ((fileinfo.attrib & _A_SUBDIR)) {  //�Ƚ��ļ������Ƿ����ļ���
				if (strcmp(fileinfo.name, ".") != 0 && strcmp(fileinfo.name, "..") != 0) {
					files.push_back(p.assign(path).append("\\").append(fileinfo.name));
					getAllFiles(p.assign(path).append("\\").append(fileinfo.name));
				}
			}
			else {
				files.push_back(p.assign(path).append("\\").append(fileinfo.name));
			}
		} while (_findnext(hFile, &fileinfo) == 0);  //Ѱ����һ�����ɹ�����0������-1
		_findclose(hFile);
	}
	return 0;
}

