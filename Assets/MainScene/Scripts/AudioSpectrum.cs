using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpectrum : MonoBehaviour {

    public AudioSource Audio;   //스펙트럼 데이터로 만들 오디오 소스
    GameObject[] SpectrumCube = new GameObject[64]; //스펙트럼을 시각적으로 보여줄 큐브 배열 64개 지정
    float[] SpectrumData = new float[64]; //스펙트럼 데이터를 받을 배열 float 64개 지정


    void Start() {
        // 반복문을 통해서 x축으로 1간격씩 나열된 큐브 64개 생성
        for (int i = 0; i < 64; i++) {
            SpectrumCube[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            SpectrumCube[i].transform.localScale = new Vector3(.5f, .5f, .5f);
            SpectrumCube[i].transform.position = new Vector3((i*.5f) - 8.75f, -1, -1);
        }
    }

    void Update() {
        //지정된 오디오 소스에서 실시간으로 스펙트럼 데이터 받아오기
        SpectrumData = Audio.GetSpectrumData(64, 0, FFTWindow.Rectangular);

        //받아온 스펙트럼 데이터를 큐브의 Scale y축 값에 대입하기
        for (int i = 0; i < 64; i++) {
            SpectrumCube[i].GetComponent<Renderer>().material.SetColor("_Color", HSBColor.ToColor(new HSBColor(Mathf.PingPong(Time.time * 1, 1), 1, 1)));
            SpectrumCube[i].transform.localScale = new Vector3(.5f, Mathf.Lerp(SpectrumCube[i].transform.localScale.y, SpectrumData[i] * 50, 0.1f), .5f);
        }
    }
}
