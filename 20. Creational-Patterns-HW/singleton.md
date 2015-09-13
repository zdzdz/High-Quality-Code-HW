##Singleton Pattern##


Singleton Pattern �u object **creational** ���p�q�|���~. �S���z �u creational, �x�p�������� �y�}�p �����~�����u�~�y�u �{���} �����x�t�p�r�p�~�u���� �~�p ���q�u�{���y. �P��-�����u���y�p�|�~��, �����z ���u�|�y �t�p ���s���p�~�y���y �����x�t�p�r�p�~�u���� �~�p �����r�u���u ���� �u�t�y�~ ���q�u�{�� ���� �{���~�{���u���u�~ �{�|�p��. Singleton Pattern �u **object** ���p�q�|���~, �x�p�������� �u �p�~�s�p�w�y���p�~ �� �r�����x�{�y���u �}�u�w�t�� ���q�u�{���y���u (��.�u. ���~�y�{�p�|�~�p���p �y�~�����p�~���y�� �{���} ���q�u�{��, �{�������� �t�p�t�u�~ �{�|�p�� �t�����w�y �y �t�����������p �~�p �t�����s�y ���q�u�{���y �t�� �~�u�s��).

**�N�u���q�����t�y�}���������p** ���� �����y�|�p�s�p�~�u �~�p Singleton Pattern �r���x�~�y�{�r�p �����y �}���t�u�|�y���p�~�u �~�p ���q�u�{���y, �{���y���� �y�}�p�� ���p�}�� �u�t�~�p �y�~�����p�~���y�� �r ���u�p�|�~�y�� ���r����. �S�p�{�p �~�p�����y�}�u��, �r �{�|�p�� *Computer* �}���w�u �t�p �y�}�p ���p�}�� �u�t�~�� �����������z�����r�� �x�p �r���x�������y�x�r���u�w�t�p�~�u �~�p �x�r���{. �B ���|�����p�z, ���u ���u �t���������~�u �����x�t�p�r�p�~�u���� �~�p �~���{���|�{�� ���p�{�y�r�p �����������z�����r�p �y �u�t�~���r���u�}�u�~�~������ �y�x�r�u�w�t�p�~�u �~�p ���p�x�|�y���u�~ �x�r���{, �{���p�z�~�y���� ���u�x���|���p�� ���u ���u ���p�x�|�y���p�r�p ���� �����p�{�r�p�~�y��.

**�W�u�|�y���u**, �{���y���� ���u �����u���|�u�t�r�p�� �����y �����y�|�p�s�p�~�u���� �~�p Singleton Pattern ���p �t�r�u:

+ �����t���y�s�������r�p�~�u �����x�t�p�r�p�~�u���� �~�p ���p�}�� �u�t�~�p �y�~�����p�~���y�� �~�p �t�p�t�u�~ �{�|�p��;
+ �����y�s�������r�p�~�u �~�p �t���������� �t�� ���p�x�y �y�~�����p�~���y��.
 
Singleton Pattern �u **�����y�|���w�y�}** �����y �~�p�|�y���y�u �~�p �{���~�{�����u�~���~�y �x�p���r�{�y �x�p �t���������� �t�� (���q���y) ���u���������y, �{���u���� �r���t�y �t�� �~�u���q�����t�y�}������ ���� ���u�~�����p�|�y�x�y���p�~�� �����y�s�������r�p�~�u �~�p �t�����������p �t�� ������.

�B �����������u���~�y�� �t�y�x�p�z�~, **�����������u�q�p���p** �~�p Singleton Pattern ���u �u �~�p�|���w�y�|�p �r ���|�u�t�~�y���u ���|�����p�y:

+  �����y �t�y�x�p�z�~ �~�p *Logger* �{�|�p�����r�u;
+  �����y �t�y�x�p�z�~ �~�p *Configuration* �{�|�p�����r�u;
+  �����y �t���������� �t�� �������t�u�|�u�~�y ���u���������y (�~�p����. ���u���y�u�~ ��������);
+  �r �{���}�q�y�~�p���y�� �� Abstract Factory �y�|�y Factory Method ���p�q�|���~�y���u, �����y �������~������ �y�x�����|�x�r�p�~�u �r �}�~���s���~�y���{���r�p �����u�t�p.

Singleton Pattern ���u **�y�}���|�u�}�u�~���y���p** �����u�x *static �����|�u* �r Singleton �{�|�p���p,  *private �{���~���������{������* �y *static public �}�u�����t*, �{���z���� �r�������p ���u���u���u�~���y�� �{���} static �����|�u����.

	using System.Runtime.CompilerServices;

    internal class Singleton
    {
        private static Singleton instance;

        private int exampleField;

        private Singleton()
        {
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                return new Singleton();
            }
            else
            {
                return instance;
            }
        }

        public void ExampleMethod()
        {
        }
    }

�P���y �y�}���|�u�}�u�~���p���y�����p �~�p Singleton Pattern **�����p�����r�p��** Singleton �{�|�p���p �y �{�|�y�u�~���p.

+ *Singleton �{�|�p���p* �t�u���y�~�y���p �}�u�����t, �{���z���� �t�p�r�p �r���x�}���w�~������ �x�p �t���������� �t�� �~�u�s���r�p���p ���~�y�{�p�|�~�p �y�~�����p�~���y��. �I�~�����p�~���y���p�~�u���� ���u ���u�p�|�y�x�y���p �{�p���� static �}�u�����t, �{�������� �����s���r�p���� �x�p �����x�t�p�r�p�~�u���� �~�p �u�t�y�~�����r�u�~�p �y�~�����p�~���y�� �~�p �{�|�p���p.
+ *�K�|�y�u�~������* �����|�����p�r�p �t���������� �t�� Singleton �{�|�p���p, �u�t�y�~�����r�u�~�� �����u�x �~�u�s���r�y�� static �}�u�����t.

**�R�|�u�t�����r�y�����p** ���� �y�x�����|�x�r�p�~�u���� �~�p Singleton Pattern ���p:

+ �����y�s�������r�p�~�u �~�p �{���~�������|�y���p�~ �t���������� �~�p �{�|�y�u�~���y���u �t�� �u�t�y�~�����r�u�~�p���p �y�~�����p�~���y�� �~�p Singleton �{�|�p���p;
+ ���p�x���y�����r�p�~�u �����~�{���y���~�p�|�~���������p �r �����p�r�~�u�~�y�u �� �s�|���q�p�|�~�y���u �������}�u�~�|�y�r�y;
+ �r���x�}���w�~������ �x�p �~�p���|�u�t���r�p�~�u �y ���p�x���y�����r�p�~�u �����~�{���y���~�p�|�~���������p �~�p Singleton �{�|�p���p;
+ �s���r�{�p�r������ �r �����p�r�~�u�~�y�u �� �������u�t�p���y�y���u �r�������� �{�|�p�����r�u;

�R�������{�������p:

![](singleton.png)