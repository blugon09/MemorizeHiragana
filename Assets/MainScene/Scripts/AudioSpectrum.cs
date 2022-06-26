using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpectrum : MonoBehaviour {

    public AudioSource Audio;   //����Ʈ�� �����ͷ� ���� ����� �ҽ�
    GameObject[] SpectrumCube = new GameObject[64]; //����Ʈ���� �ð������� ������ ť�� �迭 64�� ����
    float[] SpectrumData = new float[64]; //����Ʈ�� �����͸� ���� �迭 float 64�� ����


    void Start() {
        // �ݺ����� ���ؼ� x������ 1���ݾ� ������ ť�� 64�� ����
        for (int i = 0; i < 64; i++) {
            SpectrumCube[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            SpectrumCube[i].transform.localScale = new Vector3(.5f, .5f, .5f);
            SpectrumCube[i].transform.position = new Vector3((i*.5f) - 8.75f, -1, -1);
        }
    }

    void Update() {
        //������ ����� �ҽ����� �ǽð����� ����Ʈ�� ������ �޾ƿ���
        SpectrumData = Audio.GetSpectrumData(64, 0, FFTWindow.Rectangular);

        //�޾ƿ� ����Ʈ�� �����͸� ť���� Scale y�� ���� �����ϱ�
        for (int i = 0; i < 64; i++) {
            SpectrumCube[i].GetComponent<Renderer>().material.SetColor("_Color", HSBColor.ToColor(new HSBColor(Mathf.PingPong(Time.time * 1, 1), 1, 1)));
            SpectrumCube[i].transform.localScale = new Vector3(.5f, Mathf.Lerp(SpectrumCube[i].transform.localScale.y, SpectrumData[i] * 50, 0.1f), .5f);
        }
    }
}
