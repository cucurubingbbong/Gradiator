## 매니저 구성 체계

### 1. Global Managers (게임 전체 단위)

- **GameManager**
  - 게임 전체 진행 상태 관리 (메뉴/로비/전투/결과 씬 흐름, 현재 일차, 난이도 등)

- **SaveManager**
  - 플레이어 데이터, 진행도, 옵션 등 저장/로드 처리

- **AudioManager**
  - BGM, SFX 재생 및 볼륨 설정 관리 

- **ConfigManager**
  - 데이터 로드 및 제공

- **UIManager**
  - 공통 UI(페이드, 팝업, 알림 등) 표시/숨김 및 UI 레이어 관리


### 2. Battle Scene Managers (전투 씬 전용)

- **BattleManager**
  - 한 판 전투의 전체 컨텍스트 관리 (참가 유닛 목록, 승패 조건, 보상 계산)

- **TurnManager**
  - 턴 순서 및 현재 턴 유닛 관리  
  - 속도 스탯을 기반으로 한 행동 순서 및 시전 턴(캐스팅 턴) 처리

- **GridManager**
  - 3D 좌표 그리드 관리 (칸 점유 여부, 이동 가능 여부, 위치 변환 등)

- **BattleUIManager**
  - 전투 HUD, 커맨드 선택창(이동/공격/스킬/수비), 행동 로그 등 전투 UI 제어

- **EnemyAIManager**
  - 적 유닛 행동 선택 로직 관리 (타겟 선택, 스킬 선택, 이동 결정 등)


### 3. Per-Unit Managers (유닛 개별 단위)

- **BuffManager (per Unit)**
  - 해당 유닛에 걸린 버프/디버프 목록 관리  
  - 지속 시간 감소, 중첩 처리, 능력치 반영/해제

- **SkillManager(per Unit)**
  - 유닛이 보유한 스킬 목록 및 쿨타임 관리  
  - 스킬 시전 요청, 시전 조건(자원/거리/타겟) 체크
