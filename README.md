# StudyUnity
Unity 학습 리포지토리


## ◎게임 기획하기
- 1단계 : 화면에 놓일 오브젝트를 모두 나열한다.
- 2단계 : 오브젝트를 움직일 수 있는 컨트롤러 스크립트를 정한다.
- 3단계 : 오브젝트를 자동으로 생성할 수 있도록 제너레이터 스크립트를 정한다.
- 4단계 : UI를 갱신할 수 있도록 감독 스크립트를 준비한다.
- 5단계 : 스크립트를 만드는 흐름을 생각한다.

## ◎Roulette[https://github.com/yun10002/StudyUnity/tree/main/Roulette]
-Rotate 메소드 : 게임 오브젝트를 현재의 각도에서 인수 값만큼 회전(x축 방향, y축 방향, z축 방향)
-2D에서는 z축을 중심으로 회전시켜야 하므로 회전 값을 세번째 인수로 지정.
-매 프레임마다 회전값 각도로 회전.
-회전 값이 양수면 시계 반대방향, 음수면 시계 방향으로 회전.

-Input.GetMouseButtonDown 메소드 : 클릭된 순간 한 번만 true 반환
-인수가 0-왼 클릭 / 1-우 클릭 / 2-가운데 클릭(휠??)

-회전 속도 늦추는 방법 : rotSpeed값에 감쇠 계수(나 같은 경우 0.996) 곱하면 됨 -> 일정한 속도(선형)로 감속하므로 움직임이 자연스러움
